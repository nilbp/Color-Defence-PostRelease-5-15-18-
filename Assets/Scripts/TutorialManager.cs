using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public int levelNumber;
    public int value; //aquesta variable s'anirà restant des de MouseManager i des de BuildManager
    private int initialValue;

    public static bool gameOver;
    public GameObject gameoverPanel;

    public GameObject endPanel;

    private ColorHUD colorHudInstance;

    public int numWaves;

    public static bool lastMinion;
    public GameObject[] panel;
    public int index = 0;

    public static TutorialManager instance;

    void Start()
    {

        initialValue = value;
        gameOver = false;
      
        instance = this;

        colorHudInstance = ColorHUD.instance;
        colorHudInstance.NoColor();

        LoadFirst();
        //Invoke("CheckLastMinion", 1);

    }

    private void Update()
    {
        CheckLastMinion();
    }

    void CheckLastMinion()
    {
        if (lastMinion)
        {
            numWaves--;
            lastMinion = false;
            if (numWaves == 0)
            {
                SetLevelMark();
                endPanel.SetActive(true);
                return;
            }

            MinionSpawn.lastMinionDead = true;
            LoadNext();
        }
        //GameOver();
    }

    void SetLevelMark() //Guarda la nova mark score i el player prefs amb el nom del nivell
    {
        int totalValue =  initialValue - MoneyManager.pigment + value ;

        if (totalValue < initialValue * 0.1)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 1)
            {
                PlayerPrefs.SetInt("" + levelNumber, 1);
                PlayerPrefs.SetInt("MarkScore", (PlayerPrefs.GetInt("MarkScore")+1));
            }
        }
        else if (totalValue < initialValue * 0.2 && totalValue > initialValue * 0.1)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 2)
            {
                PlayerPrefs.SetInt("" + levelNumber, 2);
                PlayerPrefs.SetInt("MarkScore", (PlayerPrefs.GetInt("MarkScore") + 2));
            }
        }
        else if (totalValue < initialValue * 0.3 && totalValue > initialValue * 0.2)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 3)
            {
                PlayerPrefs.SetInt("" + levelNumber, 3);
                PlayerPrefs.SetInt("MarkScore", (PlayerPrefs.GetInt("MarkScore") + 3));
            }
        }
        else if (totalValue < initialValue * 0.4 && totalValue < initialValue * 0.3)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 4)
            {
                PlayerPrefs.SetInt("" + levelNumber, 4);
                PlayerPrefs.SetInt("MarkScore", (PlayerPrefs.GetInt("MarkScore") + 4));
            }
        }
        else if (totalValue < initialValue * 0.5 && totalValue < initialValue * 0.4)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 5)
            {
                PlayerPrefs.SetInt("" + levelNumber, 5);
                PlayerPrefs.SetInt("MarkScore", (PlayerPrefs.GetInt("MarkScore") + 5));
            }
        }
        else if (totalValue >= initialValue * 0.6)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 7)
            {
                PlayerPrefs.SetInt("" + levelNumber, 7);
                PlayerPrefs.SetInt("MarkScore", (PlayerPrefs.GetInt("MarkScore") + 7));
            }
        }
    }

    public void LoadNext()
    {
        index++;

        if (panel[index] == null) return;

        Time.timeScale = 0;
        panel[index].SetActive(true);

        if (colorHudInstance != null)
            colorHudInstance.NoColor();


        if (panel[index - 1] == null) return;

        else panel[index - 1].SetActive(false);
    }

    public void LoadLast()
    {
        panel[index].SetActive(false);

        Time.timeScale = 1;

    }

    public void LoadFirst()
    {
        if (panel[0] == null) return;

        Time.timeScale = 0;
        panel[0].SetActive(true);

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {

        gameoverPanel.SetActive(true);

        Invoke("ChangeLevel", 3.5f);
    }

    void ChangeLevel()
    {
        gameoverPanel.SetActive(false);  
        SceneManager.LoadScene("lvlSelector");
        
    }
}

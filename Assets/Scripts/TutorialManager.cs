﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public static int darkPigment = 0;
    public static int comboBonus = 0;
    public int gradeBonus;

    public Text comboBonusText;
    public Text gradeBonusText;
    public Text minionAbsorvedText;
    public Text totalDarkPigmentText;
    public GameObject gradeImage;

    public Sprite A_Plus;
    public Sprite A;
    public Sprite B;
    public Sprite C;
    public Sprite D;
    public Sprite E;

    public int levelNumber;
    public static int value; //aquesta variable s'anirà restant des de MouseManager i des de BuildManager
    private int initialValue;

    public static bool gameOver;
    public GameObject gameoverPanel;

    public GameObject levelPassedPanel;

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
                SetLevelPanelAtributes();
                return;
            }

            MinionSpawn.lastMinionDead = true;
            LoadNext();
        }
        //GameOver();
    }

    void SetLevelPanelAtributes()
    {
        levelPassedPanel.SetActive(true);
        minionAbsorvedText.text =   "MINION BONUS           " + darkPigment*3;
        comboBonusText.text =       "COMBO BONUS            " + comboBonus*11;
        gradeBonusText.text =       "GRADE BONUS            " + gradeBonus*5;

        totalDarkPigmentText.text = "TOTAL                  " + (darkPigment*3 + comboBonus*11 + gradeBonus*5);

        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + (darkPigment*3 + comboBonus*11 + gradeBonus*5));

       
    }

    void SetLevelMark() //Guarda la nova mark score i el player prefs amb el nom del nivell
    {
        int totalValue = value + MoneyManager.pigment ;
        Debug.Log(" value =  " + value);
        Debug.Log(totalValue);

        Debug.Log("initialValue" + initialValue);

        if (totalValue < initialValue * 0.1)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 1)
            {
                PlayerPrefs.SetInt("" + levelNumber, 1);
            }
            gradeBonus = 1;
            gradeImage.GetComponent<Image>().sprite = E;
        }
        else if (totalValue < initialValue * 0.2 && totalValue > initialValue * 0.1)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 2)
            {
                PlayerPrefs.SetInt("" + levelNumber, 2);
            }
            gradeBonus = 2;
            gradeImage.GetComponent<Image>().sprite = D;
        }
        else if (totalValue < initialValue * 0.3 && totalValue > initialValue * 0.2)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 3)
            {
                PlayerPrefs.SetInt("" + levelNumber, 3);
            }
            gradeBonus = 3;
            gradeImage.GetComponent<Image>().sprite = C;
        }
        else if (totalValue < initialValue * 0.4 && totalValue < initialValue * 0.3)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 4)
            {
                PlayerPrefs.SetInt("" + levelNumber, 4);
            }
            gradeBonus = 4;
            gradeImage.GetComponent<Image>().sprite = B;
        }
        else if (totalValue < initialValue * 0.5 && totalValue < initialValue * 0.4)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 5)
            {
                PlayerPrefs.SetInt("" + levelNumber, 5);
            }
            gradeBonus = 5;
            gradeImage.GetComponent<Image>().sprite = A;
        }
        else if (totalValue >= initialValue * 0.6)
        {
            if (PlayerPrefs.GetInt("" + levelNumber) < 7)
            {
                PlayerPrefs.SetInt("" + levelNumber, 7);
            }
            gradeBonus = 7;
            gradeImage.GetComponent<Image>().sprite = A_Plus;
            Debug.Log("A+ image");
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

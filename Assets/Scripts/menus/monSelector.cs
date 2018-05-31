using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class monSelector : MonoBehaviour {

    const int LEVELS = 30;
    public Text worldMark;
    private int totalMark;

    public Sprite A_Plus;
    public Sprite A;
    public Sprite B;
    public Sprite C;
    public Sprite D;
    public Sprite E;

    public static monSelector instance;

    void Start () 
	{
        instance = this;

        UpdateWorldMark();
        /*levelReached = PlayerPrefs.GetInt ("levelReached");

        for (int i = 0; i < levelButtons.Length; i++) {
            if (i-1 < levelReached)
            {
                if (levelButtons[i] != null)
                {
                    levelButtons[i].interactable = true;
                    locks[i].gameObject.SetActive(false);
                }
            }
		}

        if (levBosc != null && levIce != null)
        {
            if (levelReached >= 10) levBosc.gameObject.SetActive(false);
            if (levelReached >= 20) levIce.gameObject.SetActive(false);              
        }*/
    }

    public Sprite GetMarkSprite(int levelMark)
    {
        switch (levelMark)
        {
            case 1:
                return E;
            case 2:
                return D;
            case 3:
                return C;
            case 4:
                return B;
            case 5:
                return A;
            case 7:
                return A_Plus;
        }
        return null;
    }

    void UpdateWorldMark()
    {
        for (int i = 0; i < LEVELS; ++i)
        {
            totalMark += PlayerPrefs.GetInt("" + i);
        }

        PlayerPrefs.SetInt("MarkScore", totalMark);
        PlayerPrefs.SetInt("MarkScore", 160);

        worldMark.text = "TOTAL MARK: " + totalMark;
    }

    public void ResetLevelProgress () 
	{
        PlayerPrefs.DeleteAll();
    }
}

  

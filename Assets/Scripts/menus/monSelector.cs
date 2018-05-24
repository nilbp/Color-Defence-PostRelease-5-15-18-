using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class monSelector : MonoBehaviour {

    const int LEVELS = 30;
    public Text worldMark;
    private int totalMark;

    void Start () 
	{
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

    void UpdateWorldMark()
    {
        for (int i = 0; i < LEVELS; ++i)
        {
            totalMark += PlayerPrefs.GetInt("" + i);
        }

        PlayerPrefs.SetInt("MarkScore", totalMark);

        worldMark.text = "TOTAL MARK:  " + totalMark;
    }


    public void ResetLevelProgress () 
	{
        PlayerPrefs.DeleteAll();
    }
}

  

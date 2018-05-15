using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Levels : MonoBehaviour {

    public GameObject locked;
    private int levelMark;

    public int markScoreToUnlock;

    void Start()
    {       
        UnlockLevel();
    }

    void UnlockLevel()
    {
        levelMark = PlayerPrefs.GetInt(gameObject.name);
        Debug.Log(PlayerPrefs.GetInt("MarkScore"));

        if (PlayerPrefs.GetInt("MarkScore") < markScoreToUnlock) return;

        locked.SetActive(false);
        GetComponent<Button>().interactable = true;
    }

}

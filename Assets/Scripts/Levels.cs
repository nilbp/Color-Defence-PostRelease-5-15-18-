using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Levels : MonoBehaviour {

    public GameObject locked;
    private int levelMark;
    public Text levelMarkText;
    public Text unlockScoreText;
    public int markScoreToUnlock;

    void Start()
    {       
        UnlockLevel();
    }

    void UnlockLevel()
    {
        levelMark = PlayerPrefs.GetInt(gameObject.name);
        levelMarkText.text = "" + levelMark;

        levelMarkText.gameObject.SetActive(false);

        if (unlockScoreText != null)
            unlockScoreText.text = "" + markScoreToUnlock;

        if (PlayerPrefs.GetInt("MarkScore") < markScoreToUnlock) return; //si passa la condició està unlocked
     
        locked.SetActive(false);

        if(unlockScoreText != null)
            unlockScoreText.gameObject.SetActive(false); //es desactiva el score que fa falta per desbloquejar el nivell perquè ja està desbloquejat

        levelMarkText.gameObject.SetActive(true); //s'activa el score que tenim
        GetComponent<Button>().interactable = true;
    }

}

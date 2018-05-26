using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Levels : MonoBehaviour {

    public GameObject locked;
    private int levelMark;
    public Image levelMarkImage;
    public Image ExamBackground;

    public Text unlockScoreText;
    public int markScoreToUnlock;

    private monSelector monSelectorInstance;

    void Start()
    {
        monSelectorInstance = monSelector.instance;
        UnlockLevel();
    }

    void UnlockLevel()
    {
        levelMark = PlayerPrefs.GetInt(gameObject.name);

        int totalMark = PlayerPrefs.GetInt("MarkScore");

        levelMarkImage.gameObject.SetActive(false);
        ExamBackground.gameObject.SetActive(false);

        if (unlockScoreText != null)
            unlockScoreText.text = totalMark + "/" + markScoreToUnlock;

        if (totalMark < markScoreToUnlock) return; //si passa la condició està unlocked

        GetComponent<Button>().interactable = true;
        locked.SetActive(false);

        if(unlockScoreText != null)
            unlockScoreText.gameObject.SetActive(false); //es desactiva el score que fa falta per desbloquejar el nivell perquè ja està desbloquejat

        if (monSelectorInstance.GetMarkSprite(levelMark) == null)
        {
            levelMarkImage.gameObject.SetActive(false);
            return;
        }
         
        levelMarkImage.sprite = monSelectorInstance.GetMarkSprite(levelMark);//posa el sprite en funció de la nota 
       
        levelMarkImage.gameObject.SetActive(true); //s'activa el score que tenim
        ExamBackground.gameObject.SetActive(true);

    }

}

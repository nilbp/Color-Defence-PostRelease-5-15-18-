using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class expedientMenu : MonoBehaviour {

    public GameObject expedientObert;
    public GameObject expedientTancat;
    public Text darkPigment;
    public Text markScore;
    int Money;
    int MarkScore;

    public void obrir()
    {
        expedientTancat.gameObject.SetActive(false);
        expedientObert.gameObject.SetActive(true);
    }

    public void tancar()
    {
        expedientTancat.gameObject.SetActive(true);
        expedientObert.gameObject.SetActive(false);
    }

    void Start ()
    {
        Money = PlayerPrefs.GetInt("Money");
        MarkScore = PlayerPrefs.GetInt("MarkScore");

        darkPigment.text = ""+Money;
        markScore.text = "" + MarkScore;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buy : MonoBehaviour {

	private int money = 10000000;

    private int moneyy;

	int moneyAmount=20;
	int tubRSold=0;

    private int buyIndex;

    bool freqtub1;
    bool freqtub2;
    bool freqtub3;
    bool freqtub4;

    public GameObject freqTub1;
    public GameObject freqTub2;
    public GameObject freqTub3;
    public GameObject freqTub4;
    public GameObject freqTub5;

    public GameObject sprayStats;
    public GameObject tubStats;

    public Button sprayActive;
    public Button tubActive;


    private void Start()
    {
        freqtub1=false;
        freqtub2=false;
        freqtub3=false;
        freqtub4=false;

        sprayActive.interactable = true;
        tubActive.interactable = true;
    }
    void Update()
    {
       // Debug.Log(money);
        moneyy = PlayerPrefs.GetInt("money");
    }

    public void buytubF1()
    {
        if (money > 100)
        {
            freqtub1 = true;
            //augment freq1
            Debug.Log("freq1");
        }
    }

    public void buytubF2()
    {
        if (freqtub1 && money > 200)
        {
            freqtub2 = true;
            //augment freq2
            Debug.Log("freq2");
        }
    }

    public void buytubF3()
    {
        if (freqtub2 && money > 200)
        {
            freqtub3 = true;
            //augment freq2
            Debug.Log("freq3");
        }
    }

    public void buytubF4()
    {
        if (freqtub3 && money > 200)
        {
            freqtub4 = true;
            //augment freq4
            Debug.Log("freq4");
        }
    }

    public void buytubF5()
    {
        if (freqtub4 && money > 200)
        {
            //augment freq5
            Debug.Log("freq5");
        }
    }

    public void activeFreqTub()
    {
        if (freqtub1 == false)
        {
            freqTub1.gameObject.SetActive(true);
        }
        if (freqtub1)
        {
            freqTub2.gameObject.SetActive(true);
        }
        if (freqtub2)
        {
            freqTub3.gameObject.SetActive(true);
        }
        if (freqtub3)
        {
            freqTub4.gameObject.SetActive(true);
        }
        if (freqtub4)
        {
            freqTub5.gameObject.SetActive(true);
        }
    }

    public void activeTub()
    {
        tubStats.gameObject.SetActive(true);
    }

    public void activeSpray()
    {
        sprayStats.gameObject.SetActive(true);
    }

}

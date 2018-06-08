using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buy : MonoBehaviour {

    public int money;

    private int moneyy;

    public Text moneyText;

    bool freqtub1=false;
    bool freqtub2 = false;
    bool freqtub3 = false;
    bool freqtub4 = false;
    bool freqtub5 = false;

    bool costtub1 = false;
    bool costtub2 = false;
    bool costtub3 = false;
    bool costtub4 = false;
    bool costtub5 = false;

    bool lifetub1 = false;
    bool lifetub2 = false;
    bool lifetub3 = false;
    bool lifetub4 = false;
    bool lifetub5 = false;

    bool freqspray1 = false;
    bool freqspray2 = false;
    bool freqspray3 = false;
    bool freqspray4 = false;
    bool freqspray5 = false;

    bool costspray1 = false;
    bool costspray2 = false;
    bool costspray3 = false;
    bool costspray4 = false;
    bool costspray5 = false;

    bool lifespray1 = false;
    bool lifespray2 = false;
    bool lifespray3 = false;
    bool lifespray4 = false;
    bool lifespray5 = false;

    public Image freqImage;
    public Image costImage;
    public Image lifeImage;

    public Image tubImage;
    public Image sprayImage;

    public GameObject freqTub1;
    public GameObject freqTub2;
    public GameObject freqTub3;
    public GameObject freqTub4;
    public GameObject freqTub5;

    public GameObject costTub1;
    public GameObject costTub2;
    public GameObject costTub3;
    public GameObject costTub4;
    public GameObject costTub5;

    public GameObject lifeTub1;
    public GameObject lifeTub2;
    public GameObject lifeTub3;
    public GameObject lifeTub4;
    public GameObject lifeTub5;

    public GameObject freqSpray1;
    public GameObject freqSpray2;
    public GameObject freqSpray3;
    public GameObject freqSpray4;
    public GameObject freqSpray5;

    public GameObject costSpray1;
    public GameObject costSpray2;
    public GameObject costSpray3;
    public GameObject costSpray4;
    public GameObject costSpray5;

    public GameObject lifeSpray1;
    public GameObject lifeSpray2;
    public GameObject lifeSpray3;
    public GameObject lifeSpray4;
    public GameObject lifeSpray5;

    public GameObject PalitofreqTub1;
    public GameObject PalitofreqTub2;
    public GameObject PalitofreqTub3;
    public GameObject PalitofreqTub4;
    public GameObject PalitofreqTub5;

    public GameObject PalitocostTub1;
    public GameObject PalitocostTub2;
    public GameObject PalitocostTub3;
    public GameObject PalitocostTub4;
    public GameObject PalitocostTub5;

    public GameObject PalitolifeTub1;
    public GameObject PalitolifeTub2;
    public GameObject PalitolifeTub3;
    public GameObject PalitolifeTub4;
    public GameObject PalitolifeTub5;

    public GameObject PalitofreqSpray1;
    public GameObject PalitofreqSpray2;
    public GameObject PalitofreqSpray3;
    public GameObject PalitofreqSpray4;
    public GameObject PalitofreqSpray5;

    public GameObject PalitocostSpray1;
    public GameObject PalitocostSpray2;
    public GameObject PalitocostSpray3;
    public GameObject PalitocostSpray4;
    public GameObject PalitocostSpray5;

    public GameObject PalitolifeSpray1;
    public GameObject PalitolifeSpray2;
    public GameObject PalitolifeSpray3;
    public GameObject PalitolifeSpray4;
    public GameObject PalitolifeSpray5;

    public GameObject sprayStats;
    public GameObject tubStats;

    public Button sprayActive;
    public Button tubActive;


    private void Start()
    {
        
        PlayerPrefs.SetInt("Money", 5000);

        money = PlayerPrefs.GetInt("Money");
        //money = 0;
        //PlayerPrefs.SetInt("Money", 0);

        sprayActive.interactable = true;
        tubActive.interactable = true;
    }

    private void Update()
    {
        moneyText.text = "" + money;
    }

    public void buytubF1()
    {
        if (money > 100)
        {
            freqtub1 = true;
            PalitofreqTub1.gameObject.SetActive(true);
            Debug.Log("freq1");
            PlayerPrefs.SetInt("Tub_Freq", 1);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
            money -= 100;
        }
    }

    public void buytubF2()
    {
        if (freqtub1 && money > 200)
        {
            freqtub2 = true;
            freqtub1 = false;
            PalitofreqTub2.gameObject.SetActive(true);
            Debug.Log("freq2");
            PlayerPrefs.SetInt("Tub_Freq", 2);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 200);
            money -= 200;
        }
    }

    public void buytubF3()
    {
        if (freqtub2 && money > 500)
        {
            freqtub3 = true;
            freqtub2 = false;
            PalitofreqTub3.gameObject.SetActive(true);
            Debug.Log("freq3");
            PlayerPrefs.SetInt("Tub_Freq", 3);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 500);
            money -= 500;

        }
    }

    public void buytubF4()
    {
        if (freqtub3 && money > 1000)
        {
            freqtub4 = true;
            freqtub3 = false;
            PalitofreqTub4.gameObject.SetActive(true);
            Debug.Log("freq4");
            PlayerPrefs.SetInt("Tub_Freq", 4);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
            money -= 1000;

        }
    }

    public void buytubF5()
    {
        if (freqtub4 && money > 2000)
        {
            freqtub5 = true;
            freqtub4 = false;
            PalitofreqTub5.gameObject.SetActive(true);
            Debug.Log("freq5");
            PlayerPrefs.SetInt("Tub_Freq", 5);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 2000);
            money -= 2000;
        }
    }

    public void activeFreqTub()
    {
        freqImage.gameObject.SetActive(true);
        costImage.gameObject.SetActive(false);
        lifeImage.gameObject.SetActive(false);

        costTub1.gameObject.SetActive(false);
        costTub2.gameObject.SetActive(false);
        costTub3.gameObject.SetActive(false);
        costTub4.gameObject.SetActive(false);
        costTub5.gameObject.SetActive(false);
        lifeTub1.gameObject.SetActive(false);
        lifeTub2.gameObject.SetActive(false);
        lifeTub3.gameObject.SetActive(false);
        lifeTub4.gameObject.SetActive(false);
        lifeTub5.gameObject.SetActive(false);

        if (freqtub1 == false)
        {
            freqTub1.gameObject.SetActive(true);
        }
        if (freqtub1)
        {
            freqTub2.gameObject.SetActive(true);
            freqTub1.gameObject.SetActive(false);
        }
        if (freqtub2)
        {
            freqTub3.gameObject.SetActive(true);
            freqTub1.gameObject.SetActive(false);
            freqTub2.gameObject.SetActive(false);
        }
        if (freqtub3)
        {
            freqTub4.gameObject.SetActive(true);
            freqTub1.gameObject.SetActive(false);
            freqTub2.gameObject.SetActive(false);
            freqTub3.gameObject.SetActive(false);
        }
        if (freqtub4)
        {
            freqTub5.gameObject.SetActive(true);
            freqTub1.gameObject.SetActive(false);
            freqTub2.gameObject.SetActive(false);
            freqTub3.gameObject.SetActive(false);
            freqTub4.gameObject.SetActive(false);
        }
    }

    public void buytubC1()
    {
        if (money > 100)
        {
            costtub1 = true;
            PalitocostTub1.gameObject.SetActive(true);
            Debug.Log("cost1");
            PlayerPrefs.SetInt("Tub_Cost", 1);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
            money -= 100;
        }
    }

    public void buytubC2()
    {
        if (costtub1 && money > 200)
        {
            costtub2 = true;
            costtub1 = false;
            PalitocostTub2.gameObject.SetActive(true);
            Debug.Log("cost2");
            PlayerPrefs.SetInt("Tub_Cost", 2);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 200);
            money -= 200;
        }
    }

    public void buytubC3()
    {
        if (costtub2 && money > 500)
        {
            costtub3 = true;
            costtub2 = false;
            PalitocostTub3.gameObject.SetActive(true);
            Debug.Log("cost3");
            PlayerPrefs.SetInt("Tub_Cost", 3);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 500);
            money -= 500;
        }
    }

    public void buytubC4()
    {
        if (costtub3 && money > 1000)
        {
            costtub4 = true;
            costtub3 = false;
            PalitocostTub4.gameObject.SetActive(true);
            Debug.Log("cost4");
            PlayerPrefs.SetInt("Tub_Cost", 4);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
            money -= 1000;
        }
    }

    public void buytubC5()
    {
        if (costtub4 && money > 2000)
        {
            costtub5 = true;
            costtub4 = false;
            PalitocostTub5.gameObject.SetActive(true);
            Debug.Log("cost5");
            PlayerPrefs.SetInt("Tub_Cost", 5);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 2000);
            money -= 2000;
        }
    }

    public void activeCostTub()
    {
        freqImage.gameObject.SetActive(false);
        costImage.gameObject.SetActive(true);
        lifeImage.gameObject.SetActive(false);

        freqTub1.gameObject.SetActive(false);
        freqTub2.gameObject.SetActive(false);
        freqTub3.gameObject.SetActive(false);
        freqTub4.gameObject.SetActive(false);
        freqTub5.gameObject.SetActive(false);
        lifeTub1.gameObject.SetActive(false);
        lifeTub2.gameObject.SetActive(false);
        lifeTub3.gameObject.SetActive(false);
        lifeTub4.gameObject.SetActive(false);
        lifeTub5.gameObject.SetActive(false);

        if (costtub1 == false)
        {
            costTub1.gameObject.SetActive(true);
        }
        if (costtub1)
        {
            costTub2.gameObject.SetActive(true);
            costTub1.gameObject.SetActive(false);
        }
        if (costtub2)
        {
            costTub3.gameObject.SetActive(true);
            costTub1.gameObject.SetActive(false);
            costTub2.gameObject.SetActive(false);
        }
        if (costtub3)
        {
            costTub4.gameObject.SetActive(true);
            costTub1.gameObject.SetActive(false);
            costTub2.gameObject.SetActive(false);
            costTub3.gameObject.SetActive(false);
        }
        if (costtub4)
        {
            costTub5.gameObject.SetActive(true);
            costTub1.gameObject.SetActive(false);
            costTub2.gameObject.SetActive(false);
            costTub3.gameObject.SetActive(false);
            costTub4.gameObject.SetActive(false);
        }
    }


    public void buytubL1()
    {
        if (money > 100)
        {
            lifetub1 = true;
            PalitolifeTub1.gameObject.SetActive(true);
            Debug.Log("life1");

            PlayerPrefs.SetInt("Tub_Life", 1);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
            money -= 100;
        }
    }

    public void buytubL2()
    {
        if (lifetub1 && money > 200)
        {
            lifetub2 = true;
            lifetub1 = false;
            PalitolifeTub2.gameObject.SetActive(true);
            Debug.Log("life2");
            PlayerPrefs.SetInt("Tub_Life", 2);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 200);
            money -= 200;
        }
    }

    public void buytubL3()
    {
        if (lifetub2 && money > 500)
        {
            lifetub3 = true;
            lifetub2 = false;
            PalitolifeTub3.gameObject.SetActive(true);
            Debug.Log("life3");
            PlayerPrefs.SetInt("Tub_Life", 3);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 500);
            money -= 500;
        }
    }

    public void buytubL4()
    {
        if (lifetub3 && money > 1000)
        {
            lifetub4 = true;
            lifetub3 = false;
            PalitolifeTub4.gameObject.SetActive(true);
            Debug.Log("life4");
            PlayerPrefs.SetInt("Tub_Life", 4);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
            money -= 1000;
        }
    }

    public void buytubL5()
    {
        if (lifetub4 && money > 2000)
        {
            lifetub5 = true;
            lifetub4 = false;
            PalitolifeTub1.gameObject.SetActive(true);
            Debug.Log("life5");
            PlayerPrefs.SetInt("Tub_Life", 5);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 2000);
            money -= 2000;
        }
    }


    public void activeLifeTub()
    {
        freqImage.gameObject.SetActive(false);
        costImage.gameObject.SetActive(false);
        lifeImage.gameObject.SetActive(true);

        freqTub1.gameObject.SetActive(false);
        freqTub2.gameObject.SetActive(false);
        freqTub3.gameObject.SetActive(false);
        freqTub4.gameObject.SetActive(false);
        freqTub5.gameObject.SetActive(false);
        costTub1.gameObject.SetActive(false);
        costTub2.gameObject.SetActive(false);
        costTub3.gameObject.SetActive(false);
        costTub4.gameObject.SetActive(false);
        costTub5.gameObject.SetActive(false);

        if (lifetub1 == false)
        {
            lifeTub1.gameObject.SetActive(true);
        }
        if (lifetub1)
        {
            lifeTub2.gameObject.SetActive(true);
            lifeTub1.gameObject.SetActive(false);
        }
        if (lifetub2)
        {
            lifeTub3.gameObject.SetActive(true);
            lifeTub1.gameObject.SetActive(false);
            lifeTub2.gameObject.SetActive(false);
        }
        if (lifetub3)
        {
            lifeTub4.gameObject.SetActive(true);
            lifeTub1.gameObject.SetActive(false);
            lifeTub2.gameObject.SetActive(false);
            lifeTub3.gameObject.SetActive(false);
        }
        if (lifetub4)
        {
            lifeTub5.gameObject.SetActive(true);
            lifeTub1.gameObject.SetActive(false);
            lifeTub2.gameObject.SetActive(false);
            lifeTub3.gameObject.SetActive(false);
            lifeTub4.gameObject.SetActive(false);
        }
    }

    public void buysprayF1()
    {
        if (money > 100)
        {
            freqspray1 = true;
            PalitofreqSpray1.gameObject.SetActive(true);
            Debug.Log("freq1");
            PlayerPrefs.SetInt("Sprai_Freq", 1);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
            money -= 100;
        }
    }

    public void buysprayF2()
    {
        if (freqspray1 && money > 200)
        {
            freqspray2 = true;
            freqspray1 = false;
            PalitofreqSpray2.gameObject.SetActive(true);
            Debug.Log("freq2");
            PlayerPrefs.SetInt("Sprai_Freq", 2);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 200);
            money -= 200;
        }
    }

    public void buysprayF3()
    {
        if (freqspray2 && money > 500)
        {
            freqspray3 = true;
            freqspray2 = false;
            PalitofreqSpray3.gameObject.SetActive(true);
            Debug.Log("freq3");
            PlayerPrefs.SetInt("Sprai_Freq", 3);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 500);
            money -= 500;
        }
    }

    public void buysprayF4()
    {
        if (freqspray3 && money > 1000)
        {
            freqspray4 = true;
            freqspray3 = false;
            PalitofreqSpray4.gameObject.SetActive(true);
            Debug.Log("freq4");
            PlayerPrefs.SetInt("Sprai_Freq", 4);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
            money -= 1000;
        }
    }

    public void buysprayF5()
    {
        if (freqspray4 && money > 2000)
        {
            freqspray5 = true;
            freqspray4 = false;
            PalitofreqSpray5.gameObject.SetActive(true);
            Debug.Log("freq5");
            PlayerPrefs.SetInt("Sprai_Freq", 5);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 2000);
            money -= 2000;
        }
    }

    public void activeFreqSpray()
    {
        freqImage.gameObject.SetActive(true);
        costImage.gameObject.SetActive(false);
        lifeImage.gameObject.SetActive(false);

        costSpray1.gameObject.SetActive(false);
        costSpray2.gameObject.SetActive(false);
        costSpray3.gameObject.SetActive(false);
        costSpray4.gameObject.SetActive(false);
        costSpray5.gameObject.SetActive(false);
        lifeSpray1.gameObject.SetActive(false);
        lifeSpray2.gameObject.SetActive(false);
        lifeSpray3.gameObject.SetActive(false);
        lifeSpray4.gameObject.SetActive(false);
        lifeSpray5.gameObject.SetActive(false);

        if (freqspray1 == false)
        {
            freqSpray1.gameObject.SetActive(true);
        }
        if (freqspray1)
        {
            freqSpray2.gameObject.SetActive(true);
            freqSpray1.gameObject.SetActive(false);
        }
        if (freqspray2)
        {
            freqSpray3.gameObject.SetActive(true);
            freqSpray1.gameObject.SetActive(false);
            freqSpray2.gameObject.SetActive(false);
        }
        if (freqspray3)
        {
            freqSpray4.gameObject.SetActive(true);
            freqSpray1.gameObject.SetActive(false);
            freqSpray2.gameObject.SetActive(false);
            freqSpray3.gameObject.SetActive(false);
        }
        if (freqspray4)
        {
            freqSpray5.gameObject.SetActive(true);
            freqSpray1.gameObject.SetActive(false);
            freqSpray2.gameObject.SetActive(false);
            freqSpray3.gameObject.SetActive(false);
            freqSpray4.gameObject.SetActive(false);
        }
    }
    
    public void buysprayC1()
    {
        if (money > 100)
        {
            costspray1 = true;
            PalitocostSpray1.gameObject.SetActive(true);
            Debug.Log("cost1");
            PlayerPrefs.SetInt("Sprai_Cost", 1);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
            money -= 100;
        }
    }

    public void buysprayC2()
    {
        if (costspray1 && money > 200)
        {
            costspray2 = true;
            costspray1 = false;
            PalitocostSpray2.gameObject.SetActive(true);
            Debug.Log("cost2");
            PlayerPrefs.SetInt("Sprai_Cost", 2);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 200);
            money -= 200;
        }
    }

    public void buysprayC3()
    {
        if (costspray2 && money > 500)
        {
            costspray3 = true;
            costspray2 = false;
            PalitocostSpray3.gameObject.SetActive(true);
            Debug.Log("cost3");
            PlayerPrefs.SetInt("Sprai_Cost", 3);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 500);
            money -= 500;
        }
    }

    public void buysprayC4()
    {
        if (costspray3 && money > 1000)
        {
            costspray4 = true;
            costspray3 = false;
            PalitocostSpray4.gameObject.SetActive(true);
            Debug.Log("cost4");
            PlayerPrefs.SetInt("Sprai_Cost", 4);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
            money -= 1000;
        }
    }

    public void buysprayC5()
    {
        if (costspray4 && money > 2000)
        {
            costspray5 = true;
            costspray4 = false;
            PalitocostSpray5.gameObject.SetActive(true);
            Debug.Log("cost5");
            PlayerPrefs.SetInt("Sprai_Cost", 5);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 2000);
            money -= 2000;
        }
    }

    public void activeCostSpray()
    {
        freqImage.gameObject.SetActive(false);
        costImage.gameObject.SetActive(true);
        lifeImage.gameObject.SetActive(false);

        freqSpray1.gameObject.SetActive(false);
        freqSpray2.gameObject.SetActive(false);
        freqSpray3.gameObject.SetActive(false);
        freqSpray4.gameObject.SetActive(false);
        freqSpray5.gameObject.SetActive(false);
        lifeSpray1.gameObject.SetActive(false);
        lifeSpray2.gameObject.SetActive(false);
        lifeSpray3.gameObject.SetActive(false);
        lifeSpray4.gameObject.SetActive(false);
        lifeSpray5.gameObject.SetActive(false);

        if (costspray1 == false)
        {
            costSpray1.gameObject.SetActive(true);
        }
        if (costspray1)
        {
            costSpray2.gameObject.SetActive(true);
            costSpray1.gameObject.SetActive(false);
        }
        if (costspray2)
        {
            costSpray3.gameObject.SetActive(true);
            costSpray1.gameObject.SetActive(false);
            costSpray2.gameObject.SetActive(false);
        }
        if (costspray3)
        {
            costSpray4.gameObject.SetActive(true);
            costSpray1.gameObject.SetActive(false);
            costSpray2.gameObject.SetActive(false);
            costSpray3.gameObject.SetActive(false);
        }
        if (costspray4)
        {
            costSpray5.gameObject.SetActive(true);
            costSpray1.gameObject.SetActive(false);
            costSpray2.gameObject.SetActive(false);
            costSpray3.gameObject.SetActive(false);
            costSpray4.gameObject.SetActive(false);
        }
    }

    public void buysprayL1()
    {
        if (money > 100)
        {
            lifespray1 = true;
            PalitolifeSpray1.gameObject.SetActive(true);
            Debug.Log("life1");
            PlayerPrefs.SetInt("Sprai_Life", 1);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
            money -= 100;
        }
    }

    public void buysprayL2()
    {
        if (lifespray1 && money > 200)
        {
            lifespray2 = true;
            lifespray1 = false;
            PalitolifeSpray2.gameObject.SetActive(true);
            Debug.Log("life2");
            PlayerPrefs.SetInt("Sprai_Life", 2);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 200);
            money -= 200;
        }
    }

    public void buysprayL3()
    {
        if (lifespray2 && money > 500)
        {
            lifespray3 = true;
            lifespray2 = false;
            PalitolifeSpray3.gameObject.SetActive(true);
            Debug.Log("life3");
            PlayerPrefs.SetInt("Sprai_Life", 3);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 500);
            money -= 500;
        }
    }

    public void buysprayL4()
    {
        if (lifespray3 && money > 1000)
        {
            lifespray4 = true;
            lifespray3 = false;
            PalitolifeSpray4.gameObject.SetActive(true);
            Debug.Log("life4");
            PlayerPrefs.SetInt("Sprai_Life", 4);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 1000);
            money -= 1000;
        }
    }

    public void buysprayL5()
    {
        if (lifespray4 && money > 2000)
        {
            lifespray5 = true;
            lifespray4 = false;
            PalitolifeSpray1.gameObject.SetActive(true);
            Debug.Log("life5");
            PlayerPrefs.SetInt("Sprai_Life", 5);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 2000);
            money -= 2000;
        }
    }

    public void activeLifeSpray()
    {
        freqImage.gameObject.SetActive(false);
        costImage.gameObject.SetActive(false);
        lifeImage.gameObject.SetActive(true);

        freqSpray1.gameObject.SetActive(false);
        freqSpray2.gameObject.SetActive(false);
        freqSpray3.gameObject.SetActive(false);
        freqSpray4.gameObject.SetActive(false);
        freqSpray5.gameObject.SetActive(false);
        costSpray1.gameObject.SetActive(false);
        costSpray2.gameObject.SetActive(false);
        costSpray3.gameObject.SetActive(false);
        costSpray4.gameObject.SetActive(false);
        costSpray5.gameObject.SetActive(false);

        if (lifespray1 == false)
        {
            lifeSpray1.gameObject.SetActive(true);
        }
        if (lifespray1)
        {
            lifeSpray2.gameObject.SetActive(true);
            lifeSpray1.gameObject.SetActive(false);
        }
        if (lifespray2)
        {
            lifeSpray3.gameObject.SetActive(true);
            lifeSpray1.gameObject.SetActive(false);
            lifeSpray2.gameObject.SetActive(false);
        }
        if (lifespray3)
        {
            lifeSpray4.gameObject.SetActive(true);
            lifeSpray1.gameObject.SetActive(false);
            lifeSpray2.gameObject.SetActive(false);
            lifeSpray3.gameObject.SetActive(false);
        }
        if (lifespray4)
        {
            lifeSpray5.gameObject.SetActive(true);
            lifeSpray1.gameObject.SetActive(false);
            lifeSpray2.gameObject.SetActive(false);
            lifeSpray3.gameObject.SetActive(false);
            lifeSpray4.gameObject.SetActive(false);
        }
    }
    
    public void activeTub()
    {
        tubStats.gameObject.SetActive(true);
        sprayStats.gameObject.SetActive(false);
        lifeSpray5.gameObject.SetActive(false);
        lifeSpray1.gameObject.SetActive(false);
        lifeSpray2.gameObject.SetActive(false);
        lifeSpray3.gameObject.SetActive(false);
        lifeSpray4.gameObject.SetActive(false);
        freqSpray1.gameObject.SetActive(false);
        freqSpray2.gameObject.SetActive(false);
        freqSpray3.gameObject.SetActive(false);
        freqSpray4.gameObject.SetActive(false);
        freqSpray5.gameObject.SetActive(false);
        costSpray1.gameObject.SetActive(false);
        costSpray2.gameObject.SetActive(false);
        costSpray3.gameObject.SetActive(false);
        costSpray4.gameObject.SetActive(false);
        costSpray5.gameObject.SetActive(false);

        sprayImage.gameObject.SetActive(false);
        tubImage.gameObject.SetActive(true);

        PalitofreqSpray1.gameObject.SetActive(false);
        PalitofreqSpray2.gameObject.SetActive(false);
        PalitofreqSpray3.gameObject.SetActive(false);
        PalitofreqSpray4.gameObject.SetActive(false);
        PalitofreqSpray5.gameObject.SetActive(false);

        PalitocostSpray1.gameObject.SetActive(false);
        PalitocostSpray2.gameObject.SetActive(false);
        PalitocostSpray3.gameObject.SetActive(false);
        PalitocostSpray4.gameObject.SetActive(false);
        PalitocostSpray5.gameObject.SetActive(false);

        PalitolifeSpray1.gameObject.SetActive(false);
        PalitolifeSpray2.gameObject.SetActive(false);
        PalitolifeSpray3.gameObject.SetActive(false);
        PalitolifeSpray4.gameObject.SetActive(false);
        PalitolifeSpray5.gameObject.SetActive(false);
    }

    public void activetubFreq()
    {
        if (freqtub1 == true)
        {
            PalitofreqTub1.gameObject.SetActive(true);
        }
        else if (freqtub2 == true)
        {
            PalitofreqTub1.gameObject.SetActive(true);
            PalitofreqTub2.gameObject.SetActive(true);
        }
        else if (freqtub3 == true)
        {
            PalitofreqTub1.gameObject.SetActive(true);
            PalitofreqTub2.gameObject.SetActive(true);
            PalitofreqTub3.gameObject.SetActive(true);
        }
        else if (freqtub4 == true)
        {
            PalitofreqTub1.gameObject.SetActive(true);
            PalitofreqTub2.gameObject.SetActive(true);
            PalitofreqTub3.gameObject.SetActive(true);
            PalitofreqTub4.gameObject.SetActive(true);
        }
        else if (freqtub5 == true)
        {
            PalitofreqTub1.gameObject.SetActive(true);
            PalitofreqTub2.gameObject.SetActive(true);
            PalitofreqTub3.gameObject.SetActive(true);
            PalitofreqTub4.gameObject.SetActive(true);
            PalitofreqTub5.gameObject.SetActive(true);
        }
    }
    public void activetubCost()
    {
        
        if (costtub1 == true)
        {
            PalitocostTub1.gameObject.SetActive(true);
        }
        else if (costtub2 == true)
        {
            PalitocostTub1.gameObject.SetActive(true);
            PalitocostTub2.gameObject.SetActive(true);
        }
        else if (costtub3 == true)
        {
            PalitocostTub1.gameObject.SetActive(true);
            PalitocostTub2.gameObject.SetActive(true);
            PalitocostTub3.gameObject.SetActive(true);
        }
        else if (costtub4 == true)
        {
            PalitocostTub1.gameObject.SetActive(true);
            PalitocostTub2.gameObject.SetActive(true);
            PalitocostTub3.gameObject.SetActive(true);
            PalitocostTub4.gameObject.SetActive(true);
        }
        else if (costtub5 == true)
        {
            PalitocostTub1.gameObject.SetActive(true);
            PalitocostTub2.gameObject.SetActive(true);
            PalitocostTub3.gameObject.SetActive(true);
            PalitocostTub4.gameObject.SetActive(true);
            PalitocostTub5.gameObject.SetActive(true);
        }
    }

   public void activetubLife()
    {
        
        if (lifetub1 == true)
        {
            PalitolifeTub1.gameObject.SetActive(true);
        }
        else if (lifetub2 == true)
        {
            PalitolifeTub1.gameObject.SetActive(true);
            PalitolifeTub2.gameObject.SetActive(true);
        }
        else if (lifetub3 == true)
        {
            PalitolifeTub1.gameObject.SetActive(true);
            PalitolifeTub2.gameObject.SetActive(true);
            PalitolifeTub3.gameObject.SetActive(true);
        }
        else if (lifetub4 == true)
        {
            PalitolifeTub1.gameObject.SetActive(true);
            PalitolifeTub2.gameObject.SetActive(true);
            PalitolifeTub3.gameObject.SetActive(true);
            PalitolifeTub4.gameObject.SetActive(true);
        }
        else if (lifetub5 == true)
        {
            PalitolifeTub1.gameObject.SetActive(true);
            PalitolifeTub2.gameObject.SetActive(true);
            PalitolifeTub3.gameObject.SetActive(true);
            PalitolifeTub4.gameObject.SetActive(true);
            PalitolifeTub5.gameObject.SetActive(true);
        }
    }

    public void activeSpray()
    {
        lifeTub5.gameObject.SetActive(false);
        lifeTub1.gameObject.SetActive(false);
        lifeTub2.gameObject.SetActive(false);
        lifeTub3.gameObject.SetActive(false);
        lifeTub4.gameObject.SetActive(false);
        freqTub1.gameObject.SetActive(false);
        freqTub2.gameObject.SetActive(false);
        freqTub3.gameObject.SetActive(false);
        freqTub4.gameObject.SetActive(false);
        freqTub5.gameObject.SetActive(false);
        costTub1.gameObject.SetActive(false);
        costTub2.gameObject.SetActive(false);
        costTub3.gameObject.SetActive(false);
        costTub4.gameObject.SetActive(false);
        costTub5.gameObject.SetActive(false);

        sprayImage.gameObject.SetActive(true);
        tubImage.gameObject.SetActive(false);

        sprayStats.gameObject.SetActive(true);
        tubStats.gameObject.SetActive(false);

        PalitofreqTub1.gameObject.SetActive(false);
        PalitofreqTub2.gameObject.SetActive(false);
        PalitofreqTub3.gameObject.SetActive(false);
        PalitofreqTub4.gameObject.SetActive(false);
        PalitofreqTub5.gameObject.SetActive(false);

        PalitocostTub1.gameObject.SetActive(false);
        PalitocostTub2.gameObject.SetActive(false);
        PalitocostTub3.gameObject.SetActive(false);
        PalitocostTub4.gameObject.SetActive(false);
        PalitocostTub5.gameObject.SetActive(false);

        PalitolifeTub1.gameObject.SetActive(false);
        PalitolifeTub2.gameObject.SetActive(false);
        PalitolifeTub3.gameObject.SetActive(false);
        PalitolifeTub4.gameObject.SetActive(false);
        PalitolifeTub5.gameObject.SetActive(false);
    }

    public void activesprayFreq()
    {
        if (freqspray1 == true)
        {
            PalitofreqSpray1.gameObject.SetActive(true);
        }
        else if (freqspray2 == true)
        {
            PalitofreqSpray1.gameObject.SetActive(true);
            PalitofreqSpray2.gameObject.SetActive(true);
        }
        else if (freqspray3 == true)
        {
            PalitofreqSpray1.gameObject.SetActive(true);
            PalitofreqSpray2.gameObject.SetActive(true);
            PalitofreqSpray3.gameObject.SetActive(true);
        }
        else if (freqspray4 == true)
        {
            PalitofreqSpray1.gameObject.SetActive(true);
            PalitofreqSpray2.gameObject.SetActive(true);
            PalitofreqSpray3.gameObject.SetActive(true);
            PalitofreqSpray4.gameObject.SetActive(true);
        }
        else if (freqspray5 == true)
        {
            PalitofreqSpray1.gameObject.SetActive(true);
            PalitofreqSpray2.gameObject.SetActive(true);
            PalitofreqSpray3.gameObject.SetActive(true);
            PalitofreqSpray4.gameObject.SetActive(true);
            PalitofreqSpray5.gameObject.SetActive(true);
        }
    }

    public void activesprayCost()
    {
        if (costspray1 == true)
        {
            PalitocostSpray1.gameObject.SetActive(true);
        }
        else if (costspray2 == true)
        {
            PalitocostSpray1.gameObject.SetActive(true);
            PalitocostSpray2.gameObject.SetActive(true);
        }
        else if (costspray3 == true)
        {
            PalitocostSpray1.gameObject.SetActive(true);
            PalitocostSpray2.gameObject.SetActive(true);
            PalitocostSpray3.gameObject.SetActive(true);
        }
        else if (costspray4 == true)
        {
            PalitocostSpray1.gameObject.SetActive(true);
            PalitocostSpray2.gameObject.SetActive(true);
            PalitocostSpray3.gameObject.SetActive(true);
            PalitocostSpray4.gameObject.SetActive(true);
        }
        else if (costspray5 == true)
        {
            PalitocostSpray1.gameObject.SetActive(true);
            PalitocostSpray2.gameObject.SetActive(true);
            PalitocostSpray3.gameObject.SetActive(true);
            PalitocostSpray4.gameObject.SetActive(true);
            PalitocostSpray5.gameObject.SetActive(true);
        }
    }

    public void activesprayLife()
    {
        if (lifespray1 == true)
        {
            PalitolifeSpray1.gameObject.SetActive(true);
        }
        else if (lifespray2 == true)
        {
           PalitolifeSpray1.gameObject.SetActive(true);
            PalitolifeSpray2.gameObject.SetActive(true);
        }
        else if (lifespray3 == true)
        {
           PalitolifeSpray1.gameObject.SetActive(true);
            PalitolifeSpray2.gameObject.SetActive(true);
            PalitolifeSpray3.gameObject.SetActive(true);
        }
        else if (lifespray4 == true)
        {
            PalitolifeSpray1.gameObject.SetActive(true);
            PalitolifeSpray2.gameObject.SetActive(true);
            PalitolifeSpray3.gameObject.SetActive(true);
            PalitolifeSpray4.gameObject.SetActive(true);
        }
        else if (lifespray5 == true)
        {
            PalitolifeSpray1.gameObject.SetActive(true);
            PalitolifeSpray2.gameObject.SetActive(true);
            PalitolifeSpray3.gameObject.SetActive(true);
            PalitolifeSpray4.gameObject.SetActive(true);
            PalitolifeSpray5.gameObject.SetActive(true);
        }
    }

}

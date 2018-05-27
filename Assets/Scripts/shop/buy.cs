using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buy : MonoBehaviour {

    public int money;

    private int moneyy;

    public Text moneyText;

    bool freqtub1;
    bool freqtub2;
    bool freqtub3;
    bool freqtub4;

    bool costtub1;
    bool costtub2;
    bool costtub3;
    bool costtub4;

    bool lifetub1;
    bool lifetub2;
    bool lifetub3;
    bool lifetub4;

    bool freqspray1;
    bool freqspray2;
    bool freqspray3;
    bool freqspray4;

    bool costspray1;
    bool costspray2;
    bool costspray3;
    bool costspray4;

    bool lifespray1;
    bool lifespray2;
    bool lifespray3;
    bool lifespray4;

    public Image freqImage;
    public Image costImage;
    public Image lifeImage;

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

    public GameObject sprayStats;
    public GameObject tubStats;

    public Button sprayActive;
    public Button tubActive;


    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");

        freqtub1 = false;
        freqtub2 = false;
        freqtub3 = false;
        freqtub4 = false;

        costtub1 = false;
        costtub2 = false;
        costtub3 = false;
        costtub4 = false;

        lifetub1 = false;
        lifetub2 = false;
        lifetub3 = false;
        lifetub4 = false;

        freqspray1 = false;
        freqspray2 = false;
        freqspray3 = false;
        freqspray4 = false;

        costspray1 = false;
        costspray2 = false;
        costspray3 = false;
        costspray4 = false;

        lifespray1 = false;
        lifespray2 = false;
        lifespray3 = false;
        lifespray4 = false;

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
            //augment freq1
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
            //augment freq2
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
            //augment freq2
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
            //augment freq4
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
            //augment freq5
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
            //augment cost1
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
            //augment cost2
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
            //augment cost3
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
            //augment cost4
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
            //augmentcost5
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
            //augment life1
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
            //augment life2
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
            //augment life3
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
            //augment life4
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
            //augment life5
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
            //augment freq1
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
            //augment freq2
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
            //augment freq2
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
            //augment freq4
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
            //augment freq5
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
            //augment cost1
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
            //augment cost2
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
            //augment cost3
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
            //augment cost4
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
            //augmentcost5
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
            //augment life1
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
            //augment life2
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
            //augment life3
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
            //augment life4
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
            //augment life5
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
        sprayStats.gameObject.SetActive(true);
        tubStats.gameObject.SetActive(false);
    }

}

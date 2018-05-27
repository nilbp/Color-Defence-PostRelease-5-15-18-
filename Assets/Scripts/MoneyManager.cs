using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoneyManager : MonoBehaviour {

    private static GameObject canvas;

    public static int pigment;

	public Text text;

	//Combo variables
	private static int combo;
	private static float contador=0;

    public GameObject combo1;
    public GameObject combo2;
    public GameObject combo3;
    public GameObject combo4;
    public GameObject combo5;

    public static GameObject combo_1;
    public static GameObject combo_2;
    public static GameObject combo_3;
    public static GameObject combo_4;
    public static GameObject combo_5;

    private static bool combo1Treigger = false;
    private static bool combo2Treigger = false;
    private static bool combo3Treigger = false;
    private static bool combo4Treigger = false;
    private static bool combo5Treigger = false;

    public GameObject MoneyPopUp;
    private static GameObject MoneyPopUp1;

    //private MinionSpawn minionSpawnInstance;

    void Start()
	{
       // minionSpawnInstance = MinionSpawn.instance;
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        MoneyPopUp1 = MoneyPopUp;

        combo_1 = combo1;
        combo_2 = combo2;
        combo_3 = combo3;
        combo_4 = combo4;
        combo_5 = combo5;     
    }

	void Update()
	{		
		text.text = " " + pigment;

		if(contador >= 0)
			contador -= Time.deltaTime;
	}

    public void PassWave()
    {
       // minionSpawnInstance.waveSecondsCounter = 0;
        MinionSpawn.waveSecondsCounter = 0;
    }

    public static void PopUpText(Transform transform, Color lastColor, int minionValue)
    {
        GameObject instance = Instantiate(MoneyPopUp1);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        instance.transform.SetParent(canvas.transform, false);
        instance.transform.position = screenPosition;

        Text PopUpText = instance.GetComponentInChildren<Text>();
        PopUpText.text = "+ " + minionValue;
        PopUpText.color = lastColor;
    }

    public static void Combo(Transform transform, int minionColorQuantity)
    {
        GameObject instance = null;

        combo+= minionColorQuantity;

        if (contador <= 0)
        {
            combo = 1;
            combo1Treigger = false;
            combo2Treigger = false;
            combo3Treigger = false;
            combo4Treigger = false;
            combo5Treigger = false;
        }

        else if (combo >= 3 && combo < 6 && !combo1Treigger)
        {
            instance = Instantiate(combo_1);
            Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
            instance.transform.SetParent(canvas.transform, false);
            instance.transform.position = screenPosition;
            combo1Treigger = true;
            pigment += 15;
            TutorialManager.comboBonus += 1;

        }
        else if (combo >= 6 && combo < 10 && !combo2Treigger)
        {
            instance = Instantiate(combo_2);
            Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
            instance.transform.SetParent(canvas.transform, false);
            instance.transform.position = screenPosition;
            combo2Treigger = true;
            pigment += 30;
            TutorialManager.comboBonus += 2;
        }
        else if (combo >= 10 && combo < 18 && !combo3Treigger)
        {
            instance = Instantiate(combo_3);
            Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
            instance.transform.SetParent(canvas.transform, false);
            instance.transform.position = screenPosition;
            combo3Treigger = true;
            pigment += 50;
            TutorialManager.comboBonus += 5;
        }
        else if (combo >= 18 && combo < 30 && !combo4Treigger)
        {
            instance = Instantiate(combo_4);
            Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
            instance.transform.SetParent(canvas.transform, false);
            instance.transform.position = screenPosition;
            combo4Treigger = true;
            pigment += 80;
            TutorialManager.comboBonus += 10;
        }
        else if (combo >= 30 && !combo5Treigger)
        {
            instance = Instantiate(combo_5 );
            Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
            instance.transform.SetParent(canvas.transform, false);
            instance.transform.position = screenPosition;
            combo5Treigger = true;
            pigment += 150;
            TutorialManager.comboBonus += 20;
        }
		contador = 3;
	}


}

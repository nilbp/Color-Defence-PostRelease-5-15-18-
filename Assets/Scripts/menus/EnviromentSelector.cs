using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnviromentSelector : MonoBehaviour
{
    const int NUM_LEVELS = 10;

    private int totalMark;

    private int savannahTotalMark = 0;
    private int forestTotalMark = 0;
    private int articTotalMark = 0;

    const int FOREST_UNLOCK_MARK = 60;
    const int ARTIC_UNLOCK_MARK = 120;

    public Text forestUnlockMark;
    public Text articUnlockMark;

    public GameObject forest;
    public GameObject artic;

    public GameObject savannah_GO;
    public GameObject forest_GO;
    public GameObject artic_GO;

    public GameObject forestLock;
    public GameObject articLock;

    public Text savannahTotalMark_Text;
    public Text forestTotalMark_Text;
    public Text articTotalMark_Text;

    void Start()
    {
        GetEnviromentsValue();
        SetImagesAndText();
        ManageLocks();
    }

    void GetEnviromentsValue()
    {
        for (int i = 0; i < NUM_LEVELS; ++i)
            savannahTotalMark += PlayerPrefs.GetInt("" + i);

        for (int i = 10; i < NUM_LEVELS*2; ++i)
            forestTotalMark += PlayerPrefs.GetInt("" + i);

        for (int i = 20; i < NUM_LEVELS*3; ++i)
            articTotalMark += PlayerPrefs.GetInt("" + i);
    }

    void SetImagesAndText()
    {
        if (savannahTotalMark <= 0) savannah_GO.SetActive(false);
        else savannah_GO.SetActive(true);

        if (forestTotalMark <= 0) forest_GO.SetActive(false);
        else forest_GO.SetActive(true); forestLock.SetActive(false);

        if (articTotalMark <= 0) artic_GO.SetActive(false);
        else artic_GO.SetActive(true);

        savannahTotalMark_Text.text = "" + savannahTotalMark;
        forestTotalMark_Text.text = "" + forestTotalMark;
        articTotalMark_Text.text = "" + articTotalMark;
    }

    void ManageLocks()
    {
        totalMark = PlayerPrefs.GetInt("MarkScore");
        Button forest_Button = forest.GetComponent<Button>();
        Button artic_Button = artic.GetComponent<Button>();

        forestUnlockMark.text = totalMark + "/" + FOREST_UNLOCK_MARK;
        articUnlockMark.text = totalMark + "/" + ARTIC_UNLOCK_MARK;

        if (totalMark >= FOREST_UNLOCK_MARK)
        {
            forestLock.SetActive(false);
            forestUnlockMark.gameObject.SetActive(false);
            forest_Button.interactable = true;
        }
        else
        {
            forestLock.SetActive(true);
            forest_Button.interactable = false;
        }

        if (totalMark >= ARTIC_UNLOCK_MARK)
        {
            articLock.SetActive(false);
            articUnlockMark.gameObject.SetActive(false);
            artic_Button.interactable = true;
        }
        else
        {
            articLock.SetActive(true);
            artic_Button.interactable = false;
        }

    }
}

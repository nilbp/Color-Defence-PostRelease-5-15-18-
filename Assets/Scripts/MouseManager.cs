using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MouseManager : MonoBehaviour
{

    int xHexPos;
    int yHexPos;

    const int  colorCost = 10;

    int costPigment = 10;

    public Texture2D DefaultText;

    public Texture2D CyanTex;
    public Texture2D MagentaTex;
    public Texture2D YellowTex;

    public static char ColorInHand;

   /* public GameObject CyanTubPinturaPrefab;
    public GameObject MagentaTubPinturaPrefab;
    public GameObject YellowTubPinturaPrefab;*/

    public Vector3 SpraiPositionOffset;
    public Vector3 TubOfset;

    //RAYCAST VARIABLES
    GameObject ourHitObject;
    RaycastHit hitInfo;
    Ray ray;

    private TutorialManager tutoInstance;

    enum NeighbourPosition
    {
        Left,
        UpLeft,
        UpRight,
        Right,
        DownRight,
        DownLeft,
        NumPositions,
    }
    void Start()
    {
        SpraiPositionOffset = new Vector3(0, 0.485f, 0);
        tutoInstance = TutorialManager.instance;
    }

    void Update()
    {

        if (EventSystem.current.IsPointerOverGameObject())
            return;

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitInfo))
        {
            ourHitObject = hitInfo.collider.transform.gameObject;

            if (ourHitObject.tag != "Hex")
                return;

            if (Input.GetMouseButtonDown(0))
            {
                HexInfo hexInfoObject = ourHitObject.GetComponentInChildren<HexInfo>();

                if (!hexInfoObject.Clickable)
                return;

                if (MoneyManager.pigment >= colorCost)
                {
                   
                    if (hexInfoObject != null)
                    {
                        MeshRenderer mr = ourHitObject.GetComponentInChildren<MeshRenderer>();

                        if (ColorInHand == 'C' && hexInfoObject.HexColor != 'C')
                        {
                            FindObjectOfType<AudioManager>().Play("Pop1");
                            hexInfoObject.HexColor = 'C';
                            hexInfoObject.SetColorTo(CyanTex);
                            MoneyManager.pigment -= colorCost;
                            tutoInstance.value -= colorCost;

                        }
                        else if (ColorInHand == 'M' && hexInfoObject.HexColor != 'M')
                        {
                            FindObjectOfType<AudioManager>().Play("Pop2");
                            hexInfoObject.HexColor = 'M';
                            hexInfoObject.SetColorTo(MagentaTex);
                            MoneyManager.pigment -= colorCost;
                            tutoInstance.value -= colorCost;

                        }
                        else if (ColorInHand == 'Y' && hexInfoObject.HexColor != 'Y')
                        {
                            FindObjectOfType<AudioManager>().Play("Pop3");
                            hexInfoObject.HexColor = 'Y';
                            hexInfoObject.SetColorTo(YellowTex);
                            MoneyManager.pigment -= colorCost;
                            tutoInstance.value -= colorCost;
                        }
                    }
                }
            }
        }
    }
}




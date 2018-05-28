using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endless : MonoBehaviour {

    public int levelNumber;

    const int START_TIME = 11;
    const int START_PIGMENT = 90;

    GameObject spawn1;

    public static bool lastMinionDead;

    bool gameOver;

    public static int waveSecondsCounter;

    public Text waveSecondsText;
    public Button passWave;
    private Text waveText;

    private int counter;

    private bool MobileBuild = false;
    const int incrementPerMobilBuild = 4;

    TutorialManager tutoInstance;

    public static endless instance;
    private ColorHUD colorHudInstance;

    //MINION PREFABS
    public GameObject minion1;
    public GameObject minion2;
    public GameObject minion3;

    private int firstSpawnPoint;
    private int lastSpawnPoint;

    //VARIABLES PEL CANVI DE COLOR
    public int cyanQuantity;
    public int magentaQuantity;
    public int yellowQuantity;

    public float EndCounter;

    public enum ColorComplexity { basic, medium, advanced, random };

    public enum Behaviour { move_Forward, mov_S, move_Random };

    public class Minion
    {
        public int size;

        //0.6 ÉS VELOCITAT RAONABLE
        public float speed;

        //1 = 1 color. 2 = 2 colors, 3 = 3 colors, 4 = random 
        public ColorComplexity colorComplexity;

        //1 = move forward, 2 = move S, 3 = move random, 4 = random
        public Behaviour behaviour;

        public int cyanQuantity;
        public int magentaQuantity;
        public int yellowQuantity;
    }

    [System.Serializable]
    public struct Waves
    {
        public float spawnRatio;
        public float startTime;
        public Minion[] minion;

    }


    void Start()
    {
 
        gameOver = false;

        MoneyManager.pigment = START_PIGMENT;

        instance = this;
        colorHudInstance = ColorHUD.instance;

        //StartCoroutine(Endless());
 
        firstSpawnPoint = 0;
        lastSpawnPoint = Map.height;
        tutoInstance = GetComponent<TutorialManager>();

        EndCounter += Time.deltaTime;

        /* waveSecondsText = GameObject.FindObjectsOfTypeAll("WaveCountDownSeconds");
         waveText = waveSecondsText.GetComponent<Text>();

         passWave = GameObject.Find("PassWaveCountdownSeconds");*/
    }

    int RandomInt(int from, int to)
    {
        return Random.Range(from, to);
    }

    //FORWARD MOVE
    void SpawnMinionBehaviour1(Minion minion, bool isLastMinion)
    {


        spawn1 = GameObject.Find("Hex_0_" + RandomInt(firstSpawnPoint, lastSpawnPoint));

        //PASSO, A L'SCRIPT DEL MINION, "HEXINFO" (NECESSARI PER QUE EL MINION SAPIGA SABER ON ÉS) I VARIABLES DE COLOR, TAMANY I VELOCITAT (PER QUE SAPIGA COM CONSTRUIR-SE)
        HexInfo spawn1Hex = spawn1.GetComponentInChildren<HexInfo>();
        MinionMovement minionScript = minion1.GetComponent<MinionMovement>();
        ColorComponents colorComponents = minion1.GetComponent<ColorComponents>();

        colorComponents.lastMinionInWave = isLastMinion;
        minionScript.ActualHex = spawn1Hex;

        //BuildMinion(minion);

        //POSA LES VARIABLES DE COLOR EN FUNCIÓ DE "MINION.SIZE" I "MINION.COLORCOMPLEXITY"
        colorComponents.cyanComponent = minion.cyanQuantity;
        colorComponents.magentaComponent = minion.magentaQuantity;
        colorComponents.yellowComponent = minion.yellowQuantity;

        //RESET DE LES VARIABLES GLOBALS DE COLOR
        cyanQuantity = 0;
        magentaQuantity = 0;
        yellowQuantity = 0;

        if (MobileBuild) minionScript.speed = minion.speed * incrementPerMobilBuild;

        else minionScript.speed = minion.speed;

        Instantiate(minion1, spawn1.transform.position, minion1.transform.rotation);
    }

    //S MOVE
    void SpawnMinionBehaviour2(Minion minion, bool isLastMinion)
    {
        //MATEIXA ESTRUCTURA QUE "FORWARD MOVE" PERO INSTANTIAN UN MINION AMB UN ALTRE COMPORTAMENT 
        spawn1 = GameObject.Find("Hex_0_" + RandomInt(firstSpawnPoint + 1, lastSpawnPoint));

        HexInfo spawn1Hex = spawn1.GetComponentInChildren<HexInfo>();
        MinionMovementS minionScript = minion2.GetComponent<MinionMovementS>();
        ColorComponents colorComponents = minion2.GetComponent<ColorComponents>();

        colorComponents.lastMinionInWave = isLastMinion;
        minionScript.ActualHex = spawn1Hex;

        //BuildMinion(minion);
        colorComponents.cyanComponent = minion.cyanQuantity;
        colorComponents.magentaComponent = minion.magentaQuantity;
        colorComponents.yellowComponent = minion.yellowQuantity;

        cyanQuantity = 0;
        magentaQuantity = 0;
        yellowQuantity = 0;

        if (MobileBuild) minionScript.speed = minion.speed * incrementPerMobilBuild;

        else minionScript.speed = minion.speed;

        Instantiate(minion2, spawn1.transform.position, minion2.transform.rotation);

    }

    //RANDOM MOVE
    void SpawnMinionBehaviour3(Minion minion, bool isLastMinion)
    {

        //MATEIXA ESTRUCTURA QUE "FORWARD MOVE" PERO INSTANTIAN UN MINION AMB UN ALTRE COMPORTAMENT 
        spawn1 = GameObject.Find("Hex_0_" + RandomInt(firstSpawnPoint, lastSpawnPoint));

        HexInfo spawn1Hex = spawn1.GetComponentInChildren<HexInfo>();
        MinionMovementRandom minionScript = minion3.GetComponent<MinionMovementRandom>();
        ColorComponents colorComponents = minion3.GetComponent<ColorComponents>();

        colorComponents.lastMinionInWave = isLastMinion;
        minionScript.ActualHex = spawn1Hex;

        //BuildMinion(minion);
        colorComponents.cyanComponent = minion.cyanQuantity;
        colorComponents.magentaComponent = minion.magentaQuantity;
        colorComponents.yellowComponent = minion.yellowQuantity;

        cyanQuantity = 0;
        magentaQuantity = 0;
        yellowQuantity = 0;

        if (MobileBuild) minionScript.speed = minion.speed * incrementPerMobilBuild;

        else minionScript.speed = minion.speed;

        Instantiate(minion3, spawn1.transform.position, minion3.transform.rotation);

    }
    void buildMinion(Minion minion)
    {
        int acum;
        int counter;
        int aux;

        switch (minion.colorComplexity)
        {
            case ColorComplexity.basic:
                acum = RandomInt(1, 4);
                if (acum == 1)
                    cyanQuantity = minion.size;
                else if (acum == 2)
                    magentaQuantity = minion.size;
                else
                    yellowQuantity = minion.size;
                break;
            case ColorComplexity.medium:
                counter = RandomInt(1, minion.size);
                acum = RandomInt(1, 4);
                if (acum == 1)
                {
                    cyanQuantity = counter;
                    magentaQuantity = minion.size - counter;
                }
                else if (acum == 2)
                {
                    yellowQuantity = counter;
                    cyanQuantity = minion.size - counter;
                }
                else
                {
                    magentaQuantity = counter;
                    yellowQuantity = minion.size - counter;
                }
                break;
            case ColorComplexity.advanced:
                counter = RandomInt(1, minion.size - 1);
                aux = RandomInt(1, minion.size - counter);

                acum = RandomInt(1, 4);
                if (acum == 1)
                {
                    cyanQuantity = counter;
                    magentaQuantity = aux;
                    yellowQuantity = minion.size - (aux + counter);
                }
                else if (acum == 2)
                {
                    yellowQuantity = counter;
                    cyanQuantity = aux;
                    magentaQuantity = minion.size - (aux + counter);
                }
                else
                {
                    magentaQuantity = counter;
                    yellowQuantity = aux;
                    cyanQuantity = minion.size - (aux + counter);
                }
                break;
            case (ColorComplexity)3:
                minion.colorComplexity = (ColorComplexity)RandomInt(1, 3);
                buildMinion(minion);
                break;
        }

    }

 /*   IEnumerator Endless()
    {
        Minion minion;
        minion.colorComplexity = 0;


        while (!gameOver && EndCounter<60)
        {
            buildMinion(minion);
            minion.behaviour=(Behaviour)RandomInt(1, 1);
            minion.colorComplexity = ColorComplexity.basic;
            minion.size = 1;
            minion.speed = 0.5f;
            Debug.Log("1");
        }
        while (!gameOver && EndCounter>=60 && EndCounter < 120)
        {
            buildMinion(minion);
            minion.behaviour = (Behaviour)RandomInt(1, 2);
            minion.colorComplexity = ColorComplexity.medium;
            minion.size = 2;
            minion.speed = 0.7f;
            Debug.Log("2");
        }
    }*/

}


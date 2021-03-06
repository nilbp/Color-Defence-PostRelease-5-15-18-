﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubDePintura : MonoBehaviour {

    const float FREQ1 = 0.3f;
    const float FREQ2 = 0.7f;
    const float FREQ3 = 1.2f;
    const float FREQ4 = 1.9f;
    const float FREQ5 = 3f;

    const int LIFE1 = 4;
    const int LIFE2 = 7;
    const int LIFE3 = 10;
    const int LIFE4 = 15;
    const int LIFE5 = 20;

    [Header("Atributes")]

	private int tubRange = 8;

    private float life = 2;

	public float range = 1.2f;
	private float FireRatio = 0.1f; //1 max!!
	public float FireCountdown = 0f;

	[Header("Unity Setup Fields")]

	public HexInfo actualHex;

	public Transform target;
	public string enemyTag = "Enemy";

	public char tubColor;

	public GameObject bulletPrefab;
	public Transform firePoint;

    //ANIMATION VARIABLES
    Animator anim;
    int shootAnimation = Animator.StringToHash("Shoot");

    //per saber el rango cap a endavant en funció el numero de hexes 
    private HexInfo[] ListOfHexesInRange;

    void Start(){

		SetRange ();
        SetTurretAtributes();
        InvokeRepeating ("UpdateTarget", 0f, 0.5f);
        anim = GetComponent<Animator>();

        GetComponentInChildren<SkinnedMeshRenderer>().material.color = SetColor(tubColor);

        
    }

    void SetTurretAtributes()
    {
        int freq = PlayerPrefs.GetInt("Tub_Freq");
        int life = PlayerPrefs.GetInt("Tub_Life");

        switch (freq)
        {
            case 1:
                FireRatio = FREQ1;
                Debug.Log("freq1");
                break;
            case 2:
                FireRatio = FREQ2;
                Debug.Log("freq2");

                break;
            case 3:
                FireRatio = FREQ3;
                Debug.Log("freq3");

                break;
            case 4:
                FireRatio = FREQ4;
                Debug.Log("freq4");

                break;
            case 5:
                FireRatio = FREQ5;
                Debug.Log("freq5");

                break;
            default:
                break;
        }

        switch (life)
        {
            case 1:
                life = LIFE1;
                Debug.Log("freq1");

                break;
            case 2:
                life = LIFE2;
                Debug.Log("freq2");

                break;
            case 3:
                life = LIFE3;
                Debug.Log("freq3");

                break;
            case 4:
                life = LIFE4;
                Debug.Log("freq4");

                break;
            case 5:
                life = LIFE5;
                Debug.Log("freq5");

                break;
            default:
                break;
        }
    }


    Color SetColor(char tubColor)
    {
        switch (tubColor)
        {
            case 'C': return Color.cyan;
            case 'M': return Color.magenta;
            case 'Y': return Color.yellow;
        }
        return Color.white;
    }

    void SetRange(){

		ListOfHexesInRange = new HexInfo[tubRange];
		HexInfo newHex = actualHex;

		for (int i = 0; i < tubRange; i++) {

			if (newHex.neigbours [0] == null)
				return;

			ListOfHexesInRange[i] = newHex.neigbours [0];
			newHex = newHex.neigbours [0];

		}
	}

	bool IsInHexRange(ColorComponents colorComponents){

		for(int i = 0; i< tubRange; i++){
			if (ListOfHexesInRange [i] == colorComponents.actualHex) 
				return true;	
		}
		return false;
	}

	void Update(){

        if (life <= 0)
        {
            Destroy(gameObject);
            return;
        }

		if (FireCountdown <= 0f && target!=null) 
		{
			Shoot ();
			FireCountdown = 1f / FireRatio;
		}

		FireCountdown -= Time.deltaTime;

	}

    void UpdateTarget()
    {
        
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        ColorComponents minion;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                if (enemy.gameObject != null)
                {
                    minion = enemy.GetComponentInParent<ColorComponents>();

                    if (IsTheMinionShootable(minion))
                    {
                        shortestDistance = distanceToEnemy;
                        nearestEnemy = enemy;
                    }
                   else
                        nearestEnemy = null; 
                }
            }
        }
        if (nearestEnemy == null)
            target = null;
        else
            target = nearestEnemy.transform;

    }

    public bool IsTheMinionShootable(ColorComponents minion)
    {
        if (!IsInHexRange(minion))
            return false;

        switch (tubColor)
        {
            case 'C':
                if (minion.cyanComponent > 0)              
                    return true;
                break;
            case 'M':
                if (minion.magentaComponent > 0)
                    return true;
                break;
            case 'Y':
                if (minion.yellowComponent > 0)
                    return true;
                break;
        }
        return false;
    }

void Shoot(){

        FindObjectOfType<AudioManager>().Play("Tub4");
        anim.SetTrigger(shootAnimation);

        GameObject bulletGO = (GameObject)Instantiate (bulletPrefab, firePoint.position, firePoint.rotation);
		Bullet bullet = bulletGO.GetComponent<Bullet> ();

		if (bullet != null) {

			bullet.chase (target);
            bullet.color = tubColor;

        }
	}
}



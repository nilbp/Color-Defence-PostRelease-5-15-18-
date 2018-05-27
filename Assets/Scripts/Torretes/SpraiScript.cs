using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpraiScript : MonoBehaviour {

    const float FREQ1 = 0.2f;
    const float FREQ2 = 0.4f;
    const float FREQ3 = 0.7f;
    const float FREQ4 = 1;
    const float FREQ5 = 1.4f;

    const int LIFE1 = 4;
    const int LIFE2 = 7;
    const int LIFE3 = 10;
    const int LIFE4 = 15;
    const int LIFE5 = 20;

    private float life = 2;

    [Header("Atributes")]

	private float range = 1.4f; //distancia entre hex i hex
	private float FireRatio = 0.1f; //3 = 3s ? 
	public float FireCountdown = 0f;

	[Header("Unity Setup Fields")]

	public HexInfo actualHex;

	public Transform target;
	public string enemyTag = "Enemy";

	public char spraiColor;

	public GameObject bulletPrefab;
	public Transform firePoint;

    public Material rangeMaterial;

    Animator anim;
    int shootAnimation = Animator.StringToHash("ShootSprai");

    void Start(){

        SetTurretAtributes();
        InvokeRepeating ("UpdateTarget", 0f, 0.5f);
        anim = GetComponent<Animator>();

        GetComponentInChildren<SkinnedMeshRenderer>().material.color = SetColor(spraiColor);

        if (actualHex == null)
            return;

        //SetRadius();
    }

    void SetTurretAtributes()
    {
        int freq = PlayerPrefs.GetInt("Sprai_Freq");
        int life = PlayerPrefs.GetInt("Sprai_Life");
        switch (freq)
        {
            case 1:
                FireRatio = FREQ1;
                break;
            case 2:
                FireRatio = FREQ2;
                break;
            case 3:
                FireRatio = FREQ3;
                break;
            case 4:
                FireRatio = FREQ4;
                break;
            case 5:
                FireRatio = FREQ5;
                break;
            default:
                break;
        }

        switch (life)
        {
            case 1:
                life = LIFE1;
                break;
            case 2:
                life = LIFE2;
                break;
            case 3:
                life = LIFE3;
                break;
            case 4:
                life = LIFE4;
                break;
            case 5:
                life = LIFE5;
                break;
            default:
                break;
        }
    }

    void SetRadius()
    {

        Color color = SetColor(spraiColor);
        color.a = 0.2f;
        for (int i = 0; i < 6; i++) {
            Renderer neighbour = actualHex.neigbours[i].GetComponentInChildren<Renderer>();
            neighbour.material = rangeMaterial;
            neighbour.material.color = color;
            
        }
    }

    Color SetColor(char spraiColor)
    {
        switch (spraiColor)
        {
            case 'C': return Color.cyan;
            case 'M': return Color.magenta;
            case 'Y': return Color.yellow;
        }
        return Color.white;
    }
	 
	void UpdateTarget(){
	
		GameObject[] enemies = GameObject.FindGameObjectsWithTag (enemyTag);
		float shortestDistance = Mathf.Infinity;
		GameObject nearestEnemy = null;
        ColorComponents minion;

        foreach (GameObject enemy in enemies) 
		{
			float distanceToEnemy = Vector3.Distance (transform.position, enemy.transform.position);
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

        if (shortestDistance > range)
        {
            target = null;
        }

        else if (nearestEnemy == null)
            target = null;
        else
            target = nearestEnemy.transform; 
    }

    public bool IsTheMinionShootable(ColorComponents minion)
    {
        switch (spraiColor)
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

    void Update(){

        if (life <= 0)
        {
            Destroy(gameObject);
            return;
        }

        if (target == null)
        {
            FireCountdown = 0;
            return;   
        }
		if (FireCountdown <= 0f) 
		{
			Shoot ();
			FireCountdown = 1f / FireRatio;
		}

		FireCountdown -= Time.deltaTime;

	}

	void Shoot(){

        //anim.SetTrigger(shootAnimation);
        FindObjectOfType<AudioManager>().Play("Pp2");
        GameObject bulletGO = (GameObject)Instantiate (bulletPrefab, firePoint.position, firePoint.rotation);
		Bullet bullet = bulletGO.GetComponent<Bullet> ();

		if (bullet != null) {

			bullet.chase (target);
            bullet.color = spraiColor;

		}	
	}


	void OnDrawGizmosSelected(){
	
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, range);
	
	}
	 
}

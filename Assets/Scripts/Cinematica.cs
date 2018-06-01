using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Cinematica : MonoBehaviour {

    bool isPlayed=false;

    public GameObject cube;

    void Start()
    {
        Debug.Log(isPlayed);

        if (Input.GetMouseButtonDown(0) || PlayerPrefs.GetInt("isPlayed") == 1)
        {
            cube.gameObject.SetActive(false);
            PlayerPrefs.SetInt("isPlayed", 1);
            //Destroy(video);

        }
    }
}

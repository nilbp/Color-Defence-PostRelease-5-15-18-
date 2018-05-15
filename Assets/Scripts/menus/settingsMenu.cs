﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class settingsMenu : MonoBehaviour {

	public AudioMixer audioMixer;

	public Dropdown resolutionDropdown;

	Resolution[] resolutions;

	void Start(){

		resolutions = Screen.resolutions;

		resolutionDropdown.ClearOptions ();

		List<string> options = new List<string> ();

		int currentResolutionIndex = 0;
		for (int i = 0; i < resolutions.Length; i++) {

			string option = resolutions [i].width + " x " + resolutions [i].height;
			options.Add (option);

			if (resolutions [i].width == Screen.currentResolution.width&&resolutions [i].height == Screen.currentResolution.height) {

				currentResolutionIndex = i;
			}
		}

		resolutionDropdown.AddOptions (options);
		resolutionDropdown.value = currentResolutionIndex;
		resolutionDropdown.RefreshShownValue ();



	}

	public void setVolume(float volume){
		audioMixer.SetFloat ("volume", volume);
	}

	public void SetQuality (int qualityIndex){

		QualitySettings.SetQualityLevel (qualityIndex);
	}

	public void setFullScreen (bool isFullScreen){

		Screen.fullScreen = isFullScreen;
	}

	public void setResolution (int resolutionIndex){

		Resolution resolution = resolutions [resolutionIndex];
		Screen.SetResolution (resolution.width, resolution.height, Screen.fullScreen);
	}
}

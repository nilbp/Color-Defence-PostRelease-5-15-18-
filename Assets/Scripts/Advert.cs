using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Advert : MonoBehaviour
{
    public void showAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("", new ShowOptions() { resultCallback = HandleShowResult });
        }
    }

    private void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            Debug.Log("Video completed - Offer a reward to the player");
            // Reward your player here.

        }
        else if (result == ShowResult.Skipped)
        {
            Debug.LogWarning("Video was skipped - Do NOT reward the player");
        }
        else if (result == ShowResult.Failed)
        {
            Debug.LogError("Video failed to show");
        }
    }
}
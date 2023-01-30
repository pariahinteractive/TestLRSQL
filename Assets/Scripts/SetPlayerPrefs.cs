using UnityEngine;
using System;

public class SetPlayerPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        // Assume here some user identification resolution happens
        // Data then needs to get stored in a persistent session on the client side, i.e. PlayerPrefs

        // User Identity Data

        // set Account and homepage for a more anonymous and contained identity:
        PlayerPrefs.SetString("LRSAccountId", "123456789");
        PlayerPrefs.SetString("LRSHomepage", "https://www.yetanalytics.com");

        // Or if you prefer, Email can be set the following way:
        PlayerPrefs.SetString("LRSEmail", "rishkuko@gmail.com");

        PlayerPrefs.SetString("LRSUsernameDisplay", "rishabh32");

        // Game Identity Data
        PlayerPrefs.SetString("LRSGameId", "http://video.games/button-clicker");
        PlayerPrefs.SetString("LRSGameDisplay", "Button Clicker");

        // Session Identity Data
        PlayerPrefs.SetString("LRSSessionIdentifier", Guid.NewGuid().ToString());
        PlayerPrefs.Save();

    }
}
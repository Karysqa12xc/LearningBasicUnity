using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public static class Utilities
{
    public static int PlayerDeaths = 0;
    public static string UpdateDeathCount(out int countReference)
    {
        countReference = 1;
        return "Next time you'll be at number" + countReference++;
    }
    public static void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    public static bool RestartLevel(int sceneIndex){
        if(sceneIndex < 0){
            throw new ArgumentException("Scene index cannot be negative");
        }
        Debug.Log("Player deaths: " + PlayerDeaths);
        string message = UpdateDeathCount(out PlayerDeaths);
        Debug.Log("Player deaths: " + PlayerDeaths);
        Debug.Log(message);
        SceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1.0f;
        return true;
    }
}

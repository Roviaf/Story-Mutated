﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void ButtonQuit()
    {
        Debug.Log("I have closed this apllication");
        Application.Quit();
    }

}

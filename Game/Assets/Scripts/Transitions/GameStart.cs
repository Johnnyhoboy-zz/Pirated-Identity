﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

    // Use this for initialization
    public void StartGame()
    {
        SceneManager.LoadScene("CutSceneAnim");
        Time.timeScale = 1f;
    }

}
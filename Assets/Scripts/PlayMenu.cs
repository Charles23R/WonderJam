﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayMenu : MonoBehaviour {

    public void PlayGame1()
    {
        SceneManager.LoadScene("Test");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("Scene2");
    }
}

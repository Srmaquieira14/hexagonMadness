﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        //FindObjectOfType<AudioManager>().Play("ButtonClick");
        FindObjectOfType<AudioManager>().Play("MenuTheme");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Boton de salir pulsado, juego cerrado");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ButtonClick()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }
}

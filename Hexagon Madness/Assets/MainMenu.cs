using System.Collections;
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
        FindObjectOfType<AudioManager>().Stop("MenuTheme");
    }

    public void StartCredits()
    {
        SceneManager.LoadScene("Credits");
        FindObjectOfType<AudioManager>().Stop("MenuTheme");
    }
    public void StartRecords()
    {
        SceneManager.LoadScene("RecordsScene");
        FindObjectOfType<AudioManager>().Stop("MenuTheme");
    }

    public void ButtonClick()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }
}

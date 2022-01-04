using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PantallaGameOver : MonoBehaviour
{
    public Text textoPuntuacion;

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("GameOver");
    }

    public void Setup(int puntuacion)
    {
        FindObjectOfType<AudioManager>().Stop("GameTheme");
        gameObject.SetActive(true);
        textoPuntuacion.text = "Puntuacion: " + puntuacion.ToString();
    }

    public void botonReiniciar()
    {
        FindObjectOfType<AudioManager>().Stop("GameOver");
        SceneManager.LoadScene("Game");
    }

    public void botonMenu()
    {
        FindObjectOfType<AudioManager>().Stop("GameOver");
        SceneManager.LoadScene("MenuScene");
    }

    public void ButtonClick()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuardarRecord : MonoBehaviour
{
    public Text textoPuntuacion;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Stop("GameTheme");
        FindObjectOfType<AudioManager>().Play("MenuTheme");
        textoPuntuacion.text = "Puntuacion: " + PantallaGameOver.puntuacionGlob.ToString();
    }

    public void botonMenu()
    {
        FindObjectOfType<AudioManager>().Stop("MenuTheme");
        SceneManager.LoadScene("MenuScene");
    }

     public void botonVolver()
    {
        FindObjectOfType<AudioManager>().Stop("MenuTheme");
        SceneManager.LoadScene("Game");
    }

    public void ButtonClick()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PantallaGameOver : MonoBehaviour
{
    public Text textoPuntuacion;

    public void Setup(int puntuacion)
    {
        gameObject.SetActive(true);
        textoPuntuacion.text = "Puntuacion: " + puntuacion.ToString();
    }

    public void botonReiniciar()
    {
        SceneManager.LoadScene("Game");
    }

    public void botonMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}

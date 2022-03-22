using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    public void Start()
    {
        //FindObjectOfType<AudioManager>().Play("ButtonClick");
        FindObjectOfType<AudioManager>().Play("GameOver");
    }

    public void ExitButton()
    { 
        FindObjectOfType<AudioManager>().Stop("GameOver");
        SceneManager.LoadScene("MenuScene");
    }

    public void ButtonClick()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }
}

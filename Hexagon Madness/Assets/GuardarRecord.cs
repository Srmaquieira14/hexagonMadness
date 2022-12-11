using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Collections.Specialized;

public class GuardarRecord : MonoBehaviour
{
    public Text textoPuntuacion;
    public Text textoError;
    public string textoInputNombre;
    private static readonly HttpClient client = new HttpClient();
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

    public async void botonGuardarRecord(){
        if(textoInputNombre != ""){
            textoError.text = "";
            Debug.Log("Boton de guardar record ha sido pulsado " + textoInputNombre);
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/records");
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //StreamReader reader = new StreamReader(response.GetResponseStream());
            //string json = reader.ReadToEnd();
            //Debug.Log(json);
            var values = new Dictionary<string, string>
            {
                { "nombre", textoInputNombre },
                { "valor", PantallaGameOver.puntuacionGlob.ToString() }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://localhost:8080/record", content);
            var responseString = await response.Content.ReadAsStringAsync();
        } else {
            textoError.text = "¡Introduzca un nombre!";
            Debug.Log("La cadena de nombre no debe ir vacia");
        }
    }

    public void leeInput(string s){
        textoInputNombre = s;
        Debug.Log(s);
    }

    public void ButtonClick()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }
}

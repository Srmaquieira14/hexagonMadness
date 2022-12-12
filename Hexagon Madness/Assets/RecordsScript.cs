using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net;
using System.IO;
using TMPro;
using Newtonsoft.Json;

public class RecordsScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void Start()
    {
        //FindObjectOfType<AudioManager>().Play("ButtonClick");
        FindObjectOfType<AudioManager>().Play("GameOver");
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/records");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
         _text.text += "\n\n";
        using (var reader2 = new JsonTextReader(new StringReader(json)))
        {
            while (reader2.Read())
            {
                if(reader2.Value + "" == "nombre"){
                    reader2.Read();
                    _text.text += reader2.Value + ": \t\t --"; 
                }
                if(reader2.Value + "" == "valor"){
                    reader2.Read();
                    _text.text += reader2.Value + "--\n\n"; 
                }
            }
        }
        //Debug.Log(json);
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

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            _text.text += "\nThis is a sample text";
        }        
    }
}


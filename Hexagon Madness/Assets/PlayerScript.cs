using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float velocidad = 400f;
    public float tiempo = 1f;
    public float tiempoSiguiente = 0f;
    float movimiento = 0f;
    public int puntuacion = 0;
    public int puntosPorSegundo;
    public PantallaGameOver pantallaGameOver;
    public Spawner spawner;
    public bool finDelJuego = false;
    // Start is called before the first frame update
    void Start()
    {
        finDelJuego = false;
        puntuacion = 0;
        puntosPorSegundo = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (!finDelJuego)
        {
            if(Time.time >= tiempoSiguiente)
            {
                puntuacion += puntosPorSegundo;
                tiempoSiguiente = Time.time + 1f / tiempo;
            }
            movimiento = Input.GetAxisRaw("Horizontal");
            transform.RotateAround(Vector3.zero, Vector3.forward, movimiento * Time.fixedDeltaTime * -velocidad);
        }
    }

    private void fixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movimiento*Time.fixedDeltaTime*-velocidad);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spawner.finalizaElJuego();
        finDelJuego = true;
        pantallaGameOver.Setup(puntuacion);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

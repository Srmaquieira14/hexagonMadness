using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float velocidad = 400f;
    float movimiento = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = Input.GetAxisRaw("Horizontal");
        transform.RotateAround(Vector3.zero, Vector3.forward, movimiento * Time.fixedDeltaTime * -velocidad);
    }

    private void fixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movimiento*Time.fixedDeltaTime*-velocidad);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

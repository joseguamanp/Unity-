using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public Transform paddle;
    public bool Getstar=false;
    public Rigidbody2D rg2d;  // la fisica de mi pelota
    float posdiferente;
    public AudioSource audi;
    void Start()
    {
        posdiferente = paddle.position.x - transform.position.x;  // se lo coloca aqui por q se lo utiliza al inicio del juego
    }

    // Update is called once per frame
    void Update()
    {
        if (Getstar==false)
        {
            
            transform.position = new Vector3(paddle.position.x - posdiferente, paddle.position.y, paddle.position.z);
            if (Input.GetMouseButton(0))
            {
                rg2d.velocity = new Vector2(9,9);
                Getstar = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        audi.Play();
    }
}

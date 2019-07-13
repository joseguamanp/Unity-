using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // para texto visual para el usuario
using UnityEngine.SceneManagement;
public class DeadZone : MonoBehaviour
{
    // se usara 2 collisiones 
    /* private void OnCollisionEnter2D(Collision2D collision)  // es cuando la pelota se choca
     {
         Debug.Log("collision");
     }
     */
    public Text puntyo; // texto de puntaje
    public Text puntenemigo;  // texto de puntaje
    public int score1; // derecha
    public int score2; // izquierda
    public NuevaScena newscena;
    private void OnTriggerEnter2D(Collider2D collision)  // es cuando atraviesa
    {
        if (gameObject.tag == "Izquierdo")
        {
            score1 = score1 + 1;
            Updatepuntaje(puntenemigo, score1);

        }
        if (gameObject.tag == "Derecho")
        {
            score2 = score2 + 1;
            Updatepuntaje(puntyo,score2);
        }
        collision.GetComponent<Pelota>().Getstar = false;
        gameover();
    }

    public void gameover()
    {
        if (score1 >= 3)
        {
            newscena.NewEscena("PerderEscena");
        }
        else if (score2 >= 3)
        {
            newscena.NewEscena("FinEscena");
        }
    }
    public void Updatepuntaje(Text nombre,int punto)
    {
        nombre.text = punto.ToString();
    }
}

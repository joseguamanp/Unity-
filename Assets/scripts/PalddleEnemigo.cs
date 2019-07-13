using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalddleEnemigo : MonoBehaviour
{
    public Transform pelota;
    public float velocidad;

    // Update is called once per frame
    void Update()
    {
        if(pelota.GetComponent<Pelota>().Getstar== true)
        {
            if(transform.position.y < pelota.position.y)
            {
                transform.position = new Vector3(transform.position.x,transform.position.y + velocidad, transform.position.z);
            }else if (transform.position.y > pelota.position.y)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - velocidad, transform.position.z);
            }
        }
    }
}

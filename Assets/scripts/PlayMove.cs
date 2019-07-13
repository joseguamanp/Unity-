using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //solo sucede una vez
    }

    // Update is called once per frame
    void Update()
    {
        //multiples veces 
        Vector3 mousePos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x,Mathf.Clamp(mousePos.y,-3.8f,3.8f),transform.position.z);
    }
}

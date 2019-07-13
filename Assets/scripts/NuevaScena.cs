using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NuevaScena : MonoBehaviour
{
    public void NewEscena(string scena)
    {
        SceneManager.LoadScene(scena);
    }
}

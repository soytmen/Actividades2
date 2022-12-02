using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act6 : MonoBehaviour
{
    public float Recorrida;
    public float Total;
    public float operation;


    private void Start()
    {
        if (Recorrida >= Total)
        {
            Debug.Log($"Enhorabuena, as recorrido todo el trayecto");
        }
        else
        {
            operation = Total - Recorrida;
            Debug.Log($"te queda {operation} pasos para terminar");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act4 : MonoBehaviour
{
    public float base1;
    public float altura1;
    private float area;


    private void Start()
    {
        if (base1 > 0 && altura1 > 0)
        {
            area = base1 * altura1 / 2;
            Debug.Log($"La area del triangulo es {area}");
        }
        else
        {
            Debug.Log($"La area no se pudo calcular");
        }

    }
}

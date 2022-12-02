using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act3 : MonoBehaviour
{
    public int numero;
    private void Start()
    {
        if (numero % 5 == 0)
        {
            Debug.Log($"Este numero es divisible por 5");
        }

    }
}

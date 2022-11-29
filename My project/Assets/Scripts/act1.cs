using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act1 : MonoBehaviour
{
    public float num = 3;

    void Start()
    {
        if (num > 0)
            Debug.Log($"{num} es positivo");
        else if (num == 0)
            Debug.Log($"{num} es 0");
        else
            Debug.Log($"´{num} es negativo");
    }


}

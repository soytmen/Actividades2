using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act10 : MonoBehaviour
{
    public int a�o;

    private void Start()
    {
        if (a�o % 4 == 0 && a�o % 100 != 0 || a�o % 400 == 0)
        {
            Debug.Log($"{a�o} es un a�o bisiesto");
        }
        else
        {
            Debug.Log($"{a�o} no es un a�o bisiesto");
        }
    }
}

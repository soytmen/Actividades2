using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act5 : MonoBehaviour
{
    public int age;

    private void Start()
    {
        if (age >= 18)
        {
            Debug.Log($" tienes {age} a�os, eres mayor de edad");
        }

        else
        {
            Debug.Log($" tienes {age} a�os, eres menor de edad");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act7 : MonoBehaviour
{
    public string calculator;
    public float num1;
    public float num2;
    private float resultado;


    private void Start()
    {
        if (calculator == "suma")
        {
            resultado = num1 + num2;
            Debug.Log($"{num1} + {num2} = {resultado}");
        }
        else if (calculator == "resta")
        {
            resultado = num1 - num2;
            Debug.Log($"{num1} - {num2} = {resultado}");
        }
        else if (calculator == "multiplicacion")
        {
            resultado = num1 * num2;
            Debug.Log($"{num1} * {num2} = {resultado}");
        }
        else if (calculator == "division")
        {
            resultado = num1 / num2;
            Debug.Log($"{num1} / {num2} = {resultado}");
        }
    }
}

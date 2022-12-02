using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act2 : MonoBehaviour
{
    public int mes;
    private int horoscopo;

    private void Start()
    {
        horoscopo = mes % 12;

        if (horoscopo == 1)
        {
            Debug.Log($"Tu horoscopo es Aries ");
        }
        else if (horoscopo == 2)
        {
            Debug.Log($"Tu horoscopo es Tauro ");
        }
        else if (horoscopo == 3)
        {
            Debug.Log($"Tu horoscopo es Geminis ");
        }
        else if (horoscopo == 4)
        {
            Debug.Log($"Tu horoscopo es Cancer ");
        }
        else if (horoscopo == 5)
        {
            Debug.Log($"Tu horoscopo es Leo ");
        }
        else if (horoscopo == 6)
        {
            Debug.Log($"Tu horoscopo es Virgo ");
        }
        else if (horoscopo == 7)
        {
            Debug.Log($"Tu horoscopo es Libra");
        }
        else if (horoscopo == 8)
        {
            Debug.Log($"Tu horoscopo es Escorpio");
        }
        else if (horoscopo == 9)
        {
            Debug.Log($"Tu horoscopo es Sagitario ");
        }
        else if (horoscopo == 10)
        {
            Debug.Log($"Tu horoscopo es Capricornio ");
        }
        else if (horoscopo == 11)
        {
            Debug.Log($"Tu horoscopo es Acuario ");
        }
        else if (horoscopo == 12)
        {
            Debug.Log($"Tu horoscopo es Piscis ");
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act9 : MonoBehaviour
{
    public bool VegetarianOption;

    private void Start()
    {
        if (VegetarianOption == true)
        {
            Debug.Log($"Opci�n no vegetariana pr�ximamente");
        }
        else
        {
            Debug.Log($"Opci�n vegetariana pr�ximamente");
        }
    }
}

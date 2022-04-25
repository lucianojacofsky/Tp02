using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_01 : MonoBehaviour
{
    public int edad;
    void Start()
    {
        if (edad >= 18)
        {
            Debug.Log("Es mayor de edad");
        }
        else
        {
            Debug.Log("No es mayor de edad");
        }
    }

}

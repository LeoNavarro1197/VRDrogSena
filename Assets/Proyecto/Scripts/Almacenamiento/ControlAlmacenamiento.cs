using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlAlmacenamiento : MonoBehaviour
{
    public string m1, m2, m3, m4, m5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(m1))
        {
            Debug.Log("Almacenamiento Correcto");
        }
        else if (other.CompareTag(m2))
        {
            Debug.Log("Almacenamiento Correcto");
        }
        else if (other.CompareTag(m3))
        {
            Debug.Log("Almacenamiento Correcto");
        }
        else if (other.CompareTag(m4))
        {
            Debug.Log("Almacenamiento Correcto");
        }
        else if (other.CompareTag(m5))
        {
            Debug.Log("Almacenamiento Correcto");
        }
        else
        {
            Debug.Log("Almacenamiento Incorrecto");
        }
    }
}

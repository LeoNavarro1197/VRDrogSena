using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalAlmacenamiento : MonoBehaviour
{
    public GameObject almacenamientoFinal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CajaAdvil") && other.CompareTag("CajaTremal") && other.CompareTag("CajaNuxpirin") && other.CompareTag("CajaEutirox") && other.CompareTag("CajaAlbendazul")
            && other.CompareTag("CajaLantus") && other.CompareTag("CajaTramadol") && other.CompareTag("CajaPlatemax") && other.CompareTag("CajaHumalug") && other.CompareTag("CajaTresiba"))
        {
            almacenamientoFinal.SetActive(true);
        }
    }
}

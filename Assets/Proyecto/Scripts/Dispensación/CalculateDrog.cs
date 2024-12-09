using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CalculateDrog : MonoBehaviour
{
    public ControlGameplay controlGameplay;

    public Animator animator, animator2, animator3;

    public bool activarCaminandoAfuera = false;

    public GameObject notidicacionAlmacenamiento;

    public GameObject inicioAlmacenamiento, UIFormula;

    private void OnTriggerEnter(Collider other)
    {
        if (controlGameplay.agent1 && other.CompareTag("CajaAdvil"))
        {
            Debug.Log("Entró Advil");
            animator.SetBool("tomar", true);
            animator.SetBool("idle", false);
            Invoke("DesaparecerObjeto", 1.08f);
            Invoke("StartIdle", 1.10f);
        }

        if (controlGameplay.agent2 && other.CompareTag("CajaLantus"))
        {
            Debug.Log("Entró Lantus");
            animator2.SetBool("tomar", true);
            animator2.SetBool("idle", false);
            Invoke("DesaparecerObjeto", 1.08f);
            Invoke("StartIdle2", 1.10f);
        }

        if (controlGameplay.agent2 && other.CompareTag("CajaAlbendazul"))
        {
            Debug.Log("Entró Albendazul");
            animator3.SetBool("tomar", true);
            animator3.SetBool("idle", false);
            Invoke("DesaparecerObjeto", 1.08f);
            Invoke("StartIdle3", 1.10f);
        }

        else
        {
            Debug.Log("Medicamento incorrecto");
        }
    }

    void StartIdle()
    {
        animator.SetBool("idle", true);
        animator.SetBool("tomar", false);
        Invoke("StartCaminando", 1);
    }

    void StartCaminando()
    {
        animator.SetBool("caminando", true);
        animator.SetBool("idle", false);
        activarCaminandoAfuera = true;
        notidicacionAlmacenamiento.SetActive(true);
        Invoke("DesaparecerNotificacionAlmacenamiento", 2);
    }

    void StartIdle2()
    {
        animator2.SetBool("idle", true);
        animator2.SetBool("tomar", false);
        Invoke("StartCaminando2", 1);
    }

    void StartCaminando2()
    {
        animator2.SetBool("caminando", true);
        animator2.SetBool("idle", false);
        activarCaminandoAfuera = true;
        notidicacionAlmacenamiento.SetActive(true);
        Invoke("DesaparecerNotificacionAlmacenamiento", 2);
    }

    void StartIdle3()
    {
        animator3.SetBool("idle", true);
        animator3.SetBool("tomar", false);
        Invoke("StartCaminando3", 1);
    }

    void StartCaminando3()
    {
        animator3.SetBool("caminando", true);
        animator3.SetBool("idle", false);
        activarCaminandoAfuera = true;
        notidicacionAlmacenamiento.SetActive(true);
        Invoke("DesaparecerNotificacionAlmacenamiento", 2);
    }

    void DesaparecerNotificacionAlmacenamiento()
    {
        UIFormula.SetActive(false);
        inicioAlmacenamiento.SetActive(true);
        notidicacionAlmacenamiento.SetActive(false);
    }
}

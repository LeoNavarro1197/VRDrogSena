using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CalculateDrog : MonoBehaviour
{
    public ControlGameplay controlGameplay;

    public Animator animator;

    public bool activarCaminandoAfuera = false;

    public GameObject advil;
    public GameObject notidicacionAlmacenamiento;

    public GameObject inicioAlmacenamiento, UIFormula;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
        else
        {
            Debug.Log("Medicamento incorrecto");
        }
    }

    void DesaparecerObjeto()
    {
        advil.SetActive(false);
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

    void DesaparecerNotificacionAlmacenamiento()
    {
        UIFormula.SetActive(false);
        inicioAlmacenamiento.SetActive(true);
        notidicacionAlmacenamiento.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CalculateDrog : MonoBehaviour
{
    public ControlGameplay controlGameplay;

    public Animator animator;

    bool bandera = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bandera)
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (controlGameplay.agent1 && other.CompareTag("CajaAdvil"))
        {
            Debug.Log("Entr� Advil, activando animaci�n tomar...");

            animator.Play("tomar", 0, 0);
            animator.SetBool("idle", false); // Aseg�rate de desactivar 'idle'
            bandera = true;

            // Espera un frame antes de verificar la animaci�n
            StartCoroutine(CheckAnimationEnd());
        }
        else
        {
            Debug.Log("Colisi�n con objeto incorrecto.");
        }
    }

    private IEnumerator CheckAnimationEnd()
    {
        yield return null; // Espera un frame para asegurarte de que la animaci�n 'tomar' comience

        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0); // Capa base

        Debug.Log("Verificando estado de animaci�n en la capa 0.");

        if (stateInfo.IsName("tomar"))
        {
            Debug.Log("La animaci�n 'tomar' est� corriendo.");

            // Verifica si la animaci�n ha terminado
            if (stateInfo.normalizedTime >= 1.0f)
            {
                Debug.Log("Animaci�n 'tomar' finalizada.");
            }
            else
            {
                Debug.Log("Animaci�n 'tomar' a�n en progreso. Tiempo normalizado: " + stateInfo.normalizedTime);
            }
        }
        else
        {
            Debug.Log("La animaci�n 'tomar' no est� activa.");
        }
    }
}

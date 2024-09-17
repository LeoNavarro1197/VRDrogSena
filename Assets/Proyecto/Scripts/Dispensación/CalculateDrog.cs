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
            Debug.Log("Entró Advil, activando animación tomar...");

            animator.Play("tomar", 0, 0);
            animator.SetBool("idle", false); // Asegúrate de desactivar 'idle'
            bandera = true;

            // Espera un frame antes de verificar la animación
            StartCoroutine(CheckAnimationEnd());
        }
        else
        {
            Debug.Log("Colisión con objeto incorrecto.");
        }
    }

    private IEnumerator CheckAnimationEnd()
    {
        yield return null; // Espera un frame para asegurarte de que la animación 'tomar' comience

        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0); // Capa base

        Debug.Log("Verificando estado de animación en la capa 0.");

        if (stateInfo.IsName("tomar"))
        {
            Debug.Log("La animación 'tomar' está corriendo.");

            // Verifica si la animación ha terminado
            if (stateInfo.normalizedTime >= 1.0f)
            {
                Debug.Log("Animación 'tomar' finalizada.");
            }
            else
            {
                Debug.Log("Animación 'tomar' aún en progreso. Tiempo normalizado: " + stateInfo.normalizedTime);
            }
        }
        else
        {
            Debug.Log("La animación 'tomar' no está activa.");
        }
    }
}

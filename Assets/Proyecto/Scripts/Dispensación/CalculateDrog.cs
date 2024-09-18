using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CalculateDrog : MonoBehaviour
{
    public ControlGameplay controlGameplay;

    public Animator animator;

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
            Invoke("StartIdle", 1.10f);
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
    }
}

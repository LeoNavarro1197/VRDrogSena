using System.Collections;
using System.Collections.Generic;
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
            Debug.Log("entro Advil");
            animator.SetBool("tomar", true);
            animator.SetBool("idle", false);
        }
        else
        {
            Debug.Log("incorrecto");
        }
    }
}

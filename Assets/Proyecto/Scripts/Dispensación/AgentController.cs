using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform point;
    bool bandera = true;

    public Animator controller;
    public AudioSource audioSource;
    public GameObject UIFormula;

    public CalculateDrog calculateDrog;

    public GameObject notificacionCliente;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bandera)
        {
            controller.SetBool("caminando", true);
            controller.SetBool("idle", false);
        }

        if (calculateDrog.activarCaminandoAfuera)
        {
            agent.destination = new Vector3(-7, 0, 6);
        }
        else
        {
            agent.destination = point.position;
        }
        /*if((agent.transform.position.x == point.position.x) && (agent.transform.position.z == point.position.z) && bandera) 
        {
            
        }
        else
        {
            
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EntradaPuerta"))
        {
            audioSource.Play();
            notificacionCliente.SetActive(true);
            Invoke("DesaparecerNotificacionCliente", 7);
        }

        if (other.CompareTag("PointClient1"))
        {
            controller.SetBool("idle", true);
            controller.SetBool("caminando", false);
            UIFormula.SetActive(true);
            bandera = false;
        }
    }

    void DesaparecerNotificacionCliente()
    {
        //notificacionCliente.SetActive(false);
    }
}


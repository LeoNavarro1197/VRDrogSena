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

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = point.position;
        
        if((agent.transform.position.x == point.position.x) && (agent.transform.position.z == point.position.z) && bandera) 
        {
            controller.SetBool("idle", true);
            controller.SetBool("caminando", false);
            UIFormula.SetActive(true);
        }
        else
        {
            controller.SetBool("caminando", true);
            controller.SetBool("idle", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EntradaPuerta"))
        {
            audioSource.Play();
        }
    }
}


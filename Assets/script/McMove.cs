using UnityEngine;
using UnityEngine.AI;

public class McMove : MonoBehaviour
{
    public Animator mouvement;
    public NavMeshAgent Agent;
    public Transform[] LocalPosition;

    bool Mooving = false;

    void Start()
    {
        mouvement = GetComponent<Animator>();
        Agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (!Mooving)
        {
            GoToNext();
        }

        if (Mooving && !Agent.pathPending && Agent.remainingDistance <= 1)
        {
            Debug.Log("Je suis arrivé");
            mouvement.SetBool("move", false);
            Mooving = false;
        }
    }

    void GoToNext()
    {
        Mooving = true;
        mouvement.SetBool("move", true);

        int index = Random.Range(0, LocalPosition.Length);
        Agent.SetDestination(LocalPosition[index].position);
    }
}
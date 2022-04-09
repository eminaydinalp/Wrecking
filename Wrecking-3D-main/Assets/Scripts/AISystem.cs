using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AISystem : MonoBehaviour
{
    [SerializeField] private Transform[] targetTransforms;
    
    private NavMeshAgent _navMeshAgent;
    private int RandomCarLookandRun;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        RandomCarLookandRun = Random.Range(0, 1);
    }

    void Update()
    {
        // if(true) return;
        AIDirectionToFace();
    }
    
    private void AIDirectionToFace()
    {
        _navMeshAgent.destination = targetTransforms[RandomCarLookandRun].position;
         Vector3 directionToFace = targetTransforms[RandomCarLookandRun].position - transform.position;
         transform.rotation = Quaternion.LookRotation(directionToFace);
    }

    public void CloseNavMeshAgent()
    {
        Debug.Log("helal");
        GetComponent<NavMeshAgent>().enabled = false;
    }

    public void DestroyYourself()
    {
        Destroy(gameObject);
    }
}

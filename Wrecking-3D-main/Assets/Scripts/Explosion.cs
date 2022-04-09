using System;
using System.Collections;
using System.Collections.Generic;
using Obi;
using UnityEngine;
using UnityEngine.AI;

public class Explosion : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float force;
    [SerializeField] private float forcex;
    [SerializeField] private float explosionRadius;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("AI")) return;
        Debug.Log("buraya gelbildinmi");
        rb = collision.gameObject.GetComponent<Rigidbody>();
        Debug.Log("AI");
        rb.AddExplosionForce(force, collision.gameObject.transform.position, explosionRadius, 0.05f, ForceMode.Impulse);
        rb.AddForce(transform.forward * forcex);
        collision.gameObject.GetComponent<AISystem>().CloseNavMeshAgent(); // çarptığı objenin scriptine git.
        
    }
}

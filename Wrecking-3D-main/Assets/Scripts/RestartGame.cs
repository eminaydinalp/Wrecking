using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            other.gameObject.GetComponent<AISystem>().DestroyYourself(); // Hangi obje değerse onu yok et.
        else
            SceneManager.LoadScene(0);
    }
}

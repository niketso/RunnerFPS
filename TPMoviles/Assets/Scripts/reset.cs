using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            SceneManager.LoadScene("ChunkTest1");
            Debug.Log("murio");
        }
    }
}

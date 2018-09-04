using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkLoader : MonoBehaviour {

    public GameObject[] items;

	// Use this for initialization
	void Start () {

        var temp = Resources.LoadAll("Chunks/", typeof(GameObject));

        items = new GameObject[temp.GetLength(0)];

        Debug.Log(items);
        int i = 0;

        foreach (GameObject chunk in temp)
        {
            items[i] = chunk;
            i++;
            Debug.Log("un chunk cargado");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

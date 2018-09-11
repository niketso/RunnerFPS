using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkLoader : MonoBehaviour {

    public GameObject[] items;
    [SerializeField]
    private Transform spawnLocation;
    [SerializeField]
    private float chunkLenght;
    private float nextChunk;
    [SerializeField]
    private float viewDistance;

    private void Start ()
    {
        //ChunkArray();
        InstatiateChunks();
	}



    /*private void ChunkArray()
    {
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
    }*/

    private void InstatiateChunks()
    {
        int rand;
        Vector3 vecChunk = new Vector3(0, 0, chunkLenght);

        for (int i = 0; i < viewDistance+10; i++)
        {
            
            rand = Random.Range(0, 5);
            Instantiate(items[rand] , spawnLocation.position , spawnLocation.rotation);
            spawnLocation.position = spawnLocation.position += vecChunk;
        }
        
    }	
}

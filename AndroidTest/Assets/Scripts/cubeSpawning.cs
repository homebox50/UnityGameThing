using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeSpawning : MonoBehaviour {

    public GameObject MasterCube;
    public float respawnTimer = 3f;
    

    GameObject cubeInstance;

    void spawnCube()
    {
        if (respawnTimer <= 0)
        {
            cubeInstance = (GameObject)Instantiate(MasterCube, transform.position, Quaternion.identity);
            respawnTimer = 3f;
        }
        

    }
    // Use this for initialization
    void Start ()
    {
        spawnCube();      
    }
	
    
	// Update is called once per frame
	void Update ()
    {
        respawnTimer -= Time.deltaTime;

		if (cubeInstance == null)
        {            
            spawnCube();           
        }
	}
}

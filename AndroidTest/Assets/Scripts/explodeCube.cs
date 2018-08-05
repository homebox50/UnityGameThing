using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeCube : MonoBehaviour {

    // Use this for initialization
    //void Start ()
    //   {

    //}


    public float m_Speed = 20f;
    


    private Vector3 m_RotationDirection = Vector3.up;

    //public int health = 5;

    //plays cube destruction animation ?
    public void destroyCube()
    {
        Destroy(gameObject);
    }

    //update score counter
    //maybe the best way to do this is just have it register the click and add the counter
    //break down into a bunch of components?
    public void acknowledgeHit()
    {
        scoreCounter.scoreValue += 1;
        //health -= 1;
    }

    //add one to the score counter
    public void incrimentCounter()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(m_RotationDirection * Time.deltaTime * m_Speed);
        //for adding health:
        //if (health <= 0)
        //{
        //  destroyCube??
        
    }
}

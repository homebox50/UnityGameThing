using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour {
    //public Transform[] target;
    public float speed;
    //GameObject foo;
    
    

    

    private int current;

    
    // Use this for initialization
    void Start ()
    {
        //Transform target1 = foo.transform.Find("target");
        //Transform target2 = foo.transform.Find("target (1)");

        //target[0] = target1;
        //target[1] = target2;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if (transform.position != target[current].position)
        //{
        //    Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
        //    GetComponent<Rigidbody>().MovePosition(pos);
        //    //GameObject.FindGameObjectsWithTag("player").MovePosition(pos);
        //}
        //else
        //{

        //    current = (current + 1) ;
        //    if (current >= target.Length)
        //    {
        //        Destroy(gameObject);
        //    }
        //}

        //this.transform.Translate(0, 0, 0.5f * Time.deltaTime * speed);
        //this.transform.Translate(0.05f, 0, 0);
        transform.Translate(speed * Time.deltaTime, 0, 0, Camera.main.transform);


    }
}

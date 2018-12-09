using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicMove : MonoBehaviour {

    public Transform ground;
    private ContactPoint2D contact;
    public float speed;
    public bool collide=false;


	void FixedUpdate () {


        if ((Input.GetKey("d"))&&(collide==false)) {
            transform.position = new Vector3(transform.position.x+speed,transform.position.z,0);
        }
        if ((Input.GetKey("a"))&&(collide==false))
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.z, 0);
        }




        //if ((Input.GetButton("Horizontal")) && (Input.GetButton("Horizontal") == false))


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        /*if (other.gameObject.transform.position.x>transform.position.x)
        {
            collide = true;
        }*/
        if (other.contacts[0].point.x > transform.position.x)
        {
            collide = true;
        }
    }


}

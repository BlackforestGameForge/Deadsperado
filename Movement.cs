using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {



    public float speed;
    private float Shelp=1;
    public float Sgain;
    public float jump;
    private bool air;
    public int tequilla;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {


       
        float moveHorizontal=Input.GetAxis("Horizontal");
        //float moveVertical  = Input.GetAxis("Vertical") ;

        //Debug.Log(moveHorizontal);
        //Debug.Log("vertical: "+moveVertical);

        
        Vector2 movement = new Vector2(moveHorizontal , 0 );

        rb.AddForce(movement *( speed*Shelp));


        //Jump
        if (Input.GetButtonDown("Jump")&(air!=true))
        {
            // vieleicht eine art longjump? rb.velocity = new Vector2(rb.velocity.x, 20f);
            rb.AddForce(Vector2.up *jump);

        }

        if ((Shelp != 2)&&(Shelp<=2))
        {
            if (Input.GetButton("Horizontal"))
            {
                Shelp = Shelp + Sgain;
            }
            //Debug.Log(Shelp);
        }
        if (Input.GetButtonUp("Horizontal"))
        {
            Shelp = 1;
        }


	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tilemap") {
            //rb.velocity = new Vector2(0,0);

        }

        air = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        air = true;
    }



    private void Update()
    {



        Debug.Log("in air?= "+air);
    }

    void OnTriggerEnter2D(Collider2D other)
    { 
        Debug.Log("Enter collision");

        if(other.gameObject.name == "tequilla")
        {
            Destroy(other.gameObject);
            tequilla = tequilla + 1;
        }
    }

    


}

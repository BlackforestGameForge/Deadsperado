using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunsystem : MonoBehaviour
{
    public Transform barrelend;
    public GameObject Projectile;
    public GameObject Shell;
    bool fire;
    public int firerate;
    int timer;
    public bool facingright;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            facingright = true;
            transform.eulerAngles=new Vector3(0, 0, 0);

        }
        if(Input.GetKey("a")) {
            facingright = false;
            transform.eulerAngles=new Vector3(0, 180, 0);
            
            }
        /*if ((facingright=false)&&(transform.eulerAngles.y == 0))
            {
                transform.Rotate(0,180,0);  }
        else { transform.Rotate(0, 0, 0); }*/
            
        timer++;

        if ((Input.GetButton("Fire1")) && (timer >= firerate))
        {
            if (facingright == true) {
                Debug.Log("jeff");
                Instantiate(Projectile, barrelend.position, transform.rotation);
                Instantiate(Shell, transform.position, transform.rotation);
                timer = 0;
            }
            else {
                Instantiate(Projectile, barrelend.position, transform.rotation);
                Instantiate(Shell, transform.position,transform.rotation);
                timer = 0;
            }


            //&&projectile.AddForce(transform.forward*thrust);    transform.position, transform.rotation,transform.forward*thrust)
        }
        Debug.Log("facingright= "+facingright);


    }
}


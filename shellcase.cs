using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shellcase : MonoBehaviour {

    public float launchPowerZ;
    public float launchPowerX;

    public Rigidbody2D rb;
    private Gunsystem niggi;
    public int time;
    private int death;
    private bool facingRight;
    private bool power = true;

    private void Start()
    {
        GameObject Player = GameObject.Find("ronny dood");
        niggi = Player.GetComponent<Gunsystem>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        
        Vector2 movement = new Vector2(launchPowerX, launchPowerZ);
        Vector2 Rmovement = new Vector2(-movement.x,launchPowerZ);


        death++;
        if (death >= time)
        {
            Destroy(gameObject);
        }

        facingRight = niggi.facingright;

        if (facingRight == true && power == true)
        {
            rb.AddForce(Rmovement);
            power = false;

        }
        if (facingRight == false && power == true)
        {
            rb.AddForce(movement);
            power = false;
        }
    }
}
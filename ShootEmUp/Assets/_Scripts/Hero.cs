using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    static public Hero S; // Singleton

    //these fields control the movement of the ship
    public float speed = 30;
    public float rollMult = -45;
    public float pitchMult = 30;

    // Ship status infomation
    public float shieldLevel = 1;
    public bool _;
    public Bounds bounds;
    private void Awake()
    {
        S = this; // Set the Singleton
        bounds = Utils.CombineBoundsOfChilderen(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Pull in infomation from the Input class
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        // Change transform.position based on the axes
        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.position = pos;

        // Rotate the ship to make it feel more dynamic
        transform.rotation = Quaternion.Euler(yAxis * pitchMult, xAxis * rollMult, 0);

        bounds.center = transform.position;

        //keep the ship constrained to the screen bounds
        Vector3 off = Utils.ScreenBoundsCheck(bounds, BoundsTest.onScreen);
        if (off != Vector3.zero)
        {
            pos -= off;
            transform.position = pos;
        }
        void OntriggerEnter(Collider other)
        {
            print("Triggered: " + other.gameObject.name);
        }
    }


}

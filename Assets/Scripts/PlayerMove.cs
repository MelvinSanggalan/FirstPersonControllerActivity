using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float rotateSpeed = 5;
    [SerializeField] private float jumpPower = 5;
    Rigidbody rb;
    public bool inAir = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter()
    {
        inAir = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if player is pressing w
        if(Input.GetKey("w"))
        {
            //move player in direction
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        else if(Input.GetKey("s"))
        {
            //move player in opposite direction
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        /*
        if(Input.GetKey("q"))
        {
            transform.Rotate(-transform.up * rotateSpeed * Time.deltaTime);
        }

        else if(Input.GetKey("e"))
        {
            transform.Rotate(transform.up * rotateSpeed * Time.deltaTime);
        }
        */

        if(Input.GetKeyDown("space") && inAir == false)
        {
            rb.AddForce(Vector3.up * jumpPower * Time.deltaTime, ForceMode.Impulse);
            inAir = true;

        }

    }
}

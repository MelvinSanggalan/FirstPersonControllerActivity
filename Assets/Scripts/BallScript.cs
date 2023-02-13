using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private float ballSpeed = 5;
    [SerializeField] private float ballimpactSpeed = -10000;
    Rigidbody rb;
     

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(ballSpeed, 0, 0);
    }

    private void OnCollisionEnter(Collision objectHit)
    {
        if (objectHit.gameObject.tag == "UpperHitBox")
        {
            rb.AddForce(ballimpactSpeed, 0, 0);
        }
    }


    // Update is called once per frame
    //void Update()
    //{

    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private Vector3 ballVelocity;
    [SerializeField] private float ballSpeed;
    Rigidbody rb;
     

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = ballVelocity * ballSpeed;
    }

    private void OnCollisionEnter(Collision collison)
    {
        if (collison.gameObject.TryGetComponent<PaddleMove>(out PaddleMove pdl))
        {
            float newX = ballVelocity.x * -1;
           rb.velocity = new Vector3(newX, 0, rb.velocity.z);
        }
    }


    // Update is called once per frame
    //void Update()
    //{

    //}
}

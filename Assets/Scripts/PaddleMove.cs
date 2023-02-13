using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    [SerializeField] private float paddleSpeed = 10;
    [SerializeField] private GameObject paddleLeft;
    [SerializeField] private GameObject paddleRight;

    private Rigidbody rbody;

    // Start is called before the first frame update
    void Start()
    {
        if(!TryGetComponent<Rigidbody>(out rbody))
        {
            Debug.Log("no rigidbody");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            paddleLeft.transform.position += transform.forward * paddleSpeed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            paddleLeft.transform.position -= transform.forward * paddleSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            paddleRight.transform.position += transform.forward * paddleSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            paddleRight.transform.position -= transform.forward * paddleSpeed * Time.deltaTime;
        }

    }
}

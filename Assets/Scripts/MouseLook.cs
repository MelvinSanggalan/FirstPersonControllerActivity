using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //mouse sensitivity
    [SerializeField] private float sens;
    //vertical clamp
    [SerializeField] private float clamp;
    //camera reference
    [SerializeField] private GameObject cam;
    //player object reference
    [SerializeField] private GameObject player;
    //float x rotation
    private float rotX;
    //float y rotation
    private float rotY;

    // Start is called before the first frame update
    void Start()
    {
        //lock the cursor to the game
        Cursor.lockState = CursorLockMode.Locked;

        //assign the x and y rotation of camera to a vector3
        Vector3 rot = transform.localRotation.eulerAngles;

        //set rotX and rotY equal to rotation of camera
        rotX = rot.x;
        rotY = rot.y;

    }

    // Update is called once per frame
    void Update()
    {
        //get mouse x and mouse y movement and assign to floats
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        //modify rotX and rotY by the mouse x and y, multipled by the sensitivity & time.deltatime
        rotX += mouseX * sens * Time.deltaTime;
        rotY += mouseY * sens * Time.deltaTime;

        //clamp x axis
        rotX = Mathf.Clamp(rotY, -clamp, clamp);

        //create local quaternium then update transform.rotation
        Quaternion localRot = Quaternion.Euler(-rotY, rotX, 0f);
        Quaternion bodyRot = Quaternion.Euler(0f, rotX, 0f);

        //update the transform.rotation
        transform.rotation = localRot;
        player.transform.rotation = bodyRot;
    }
}

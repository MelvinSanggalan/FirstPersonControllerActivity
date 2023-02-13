using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour, IInteraction
{
    [SerializeField] Inventory inventory;

    private bool locked;

    public void Activate()
    {
        if(inventory.key1 == true && locked == true)
        {
            locked = false;
            Debug.Log("Lock opens");
        }
        else if(inventory.key1 == true && locked == false)
        {
            Debug.Log("Lock already opened");
        }
        else
        {
            Debug.Log("No key found");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

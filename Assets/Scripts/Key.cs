using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour, IInteraction
{

    [SerializeField] Inventory inventory;

    public void Activate()
    {
        inventory.PickupKey();
        Debug.Log("Key has been found");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

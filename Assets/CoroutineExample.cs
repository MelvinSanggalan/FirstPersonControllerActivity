using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndPrint(1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        Debug.Log("First message. No time has passed.");
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Second message. " + waitTime + " seconds have passed.");
        yield return new WaitForSeconds(waitTime + 4);
        Debug.Log("Third message. " + waitTime + 1 + " seconds have passed.");

    }



}

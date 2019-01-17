using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyComponent : MonoBehaviour
{
    public Vector3 myVector;

    // Start is called before the first frame update
    // We have made this Start() return an IEnumerator, so it acts as a coroutine (https://docs.unity3d.com/Manual/Coroutines.html)
    IEnumerator Start()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(1);
        Debug.Log("Start (after 1 second)");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = myVector;
    }

    private void Do() {
        
    }
}

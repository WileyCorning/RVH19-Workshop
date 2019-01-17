using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPoker : MonoBehaviour
{
    private Camera myCamera;

    void Start() {
        // Get the camera attached to this gameobject
        myCamera = GetComponent<Camera>();
    }
    
    // Update is called once per frame
    void Update()
    {
        // Was the primary mouse button pressed on this frame?
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Click");

            // Get the ray emanating forward from the cursor's position with respect to our camera
            Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);

            // Declare a RaycastHit variable to store the result of our Raycast operation
            RaycastHit hit;
            
            // Does the ray intersect a collider?
            if(Physics.Raycast(ray,out hit)) {
                Debug.Log("Hit!");

                // Look for a component of type SpawnPrefabWhenPoked on the same gameobject as the collider
                var target = hit.collider.GetComponent<SpawnPrefabWhenPoked>();
                
                // Is there such a component?
                if(target != null) {
                    Debug.Log("Target!");

                    target.Poke();
                }

            }
        }
    }
}

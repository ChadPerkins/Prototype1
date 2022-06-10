using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variables:
    
    // Create an empty game object called player which can
    // be referenced in the Unity Inspector
    public GameObject player;

    // Create an offset for the camera's position
    private Vector3 cameraOffset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Set the camera to follow the player's position
        transform.position = player.transform.position + cameraOffset;
    }
}

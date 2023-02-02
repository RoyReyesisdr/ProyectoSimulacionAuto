using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    Vector3 spawnPoint;
    Quaternion originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform.position;
        originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

        float yPosition = transform.position.y;

        if(Input.GetKey(KeyCode.Tab) || yPosition < -2){

            transform.position = spawnPoint;    
            transform.rotation = originalRotation;

        }
    }
}

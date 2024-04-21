using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] Transform mainCamera;
    [SerializeField] CameraFollow camFollow;
    [SerializeField] Transform camera1;
    [SerializeField] Transform camera2;
    [SerializeField] PlayerMovement Bloopy;
    [SerializeField] PlayerMovement Gloopy;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            if(Bloopy.active) {
                
                camFollow.target = camera2;
                Bloopy.active = false;
                Gloopy.active = true;
                Bloopy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                Gloopy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
            else {
                camFollow.target = camera1;
                Bloopy.active = true;
                Gloopy.active = false;
                Bloopy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Gloopy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            }
        }
    }
}

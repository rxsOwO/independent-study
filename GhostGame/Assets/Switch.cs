using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] Camera camera1;
    [SerializeField] Camera camera2;
    [SerializeField] PlayerMovement Bloopy;
    [SerializeField] PlayerMovement Gloopy;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            if(Bloopy.active) {
                Bloopy.active = false;
                Gloopy.active = true;
                camera1.enabled = false;
                camera2.enabled = true;
            }
            else {
                Bloopy.active = true;
                Gloopy.active = false;
                camera1.enabled = true;
                camera2.enabled = false;
            }
        }
    }
}

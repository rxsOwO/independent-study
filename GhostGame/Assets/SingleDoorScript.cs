using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleDoorScript : MonoBehaviour
{
    public bool hasBloopy;
    public GameObject thing;
    public GameObject door;

    public AudioSource audio;

    public bool Open;

    void Update() {
        if(hasBloopy) {
            thing.SetActive(true);
        }
        if(hasBloopy) {
            door.SetActive(false);
            if(!Open) {
                audio.Play();
                Open = true;
            }
        }
        else {
            Open = false;
            door.SetActive(true);
            thing.SetActive(false);
        }
    }
}

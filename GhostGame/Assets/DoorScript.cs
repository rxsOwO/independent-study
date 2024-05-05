using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool hasBloopy;
    public bool hasGloopy;
    public GameObject thing;
    public GameObject thing2;
    public GameObject door;

    public AudioSource audio;

    public bool Open;

    void Update() {
        if(hasBloopy) {
            thing.SetActive(true);
        }
        else {
            thing.SetActive(false);
        }
        if (hasGloopy) {
            thing2.SetActive(true);
        }        
        else {
            thing2.SetActive(false);
        }
        if(hasBloopy && hasGloopy) {
            door.SetActive(false);
            if(!Open) {
                audio.Play();
                Open = true;
            }
        }
        else {
            Open = false;
            door.SetActive(true);
        }
    }
}

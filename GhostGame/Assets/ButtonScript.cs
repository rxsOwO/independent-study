using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject Door;
    public DoorScript DoorScr;
    public string Key;
    public LightUpCable cable;

    public AudioSource blip;
    // Start is called before the first frame update
    void Start()
    {
        DoorScr = Door.GetComponent<DoorScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col) {
        Debug.Log(col);
        Debug.Log(col.gameObject.name == Key);
        if(col.gameObject.name == Key || col.gameObject.name == Key + "Box") {
            if(Key == "Gloopy") {
                DoorScr.hasGloopy = true;
                cable.ColorOn();
                if(!(DoorScr.hasBloopy && DoorScr.hasGloopy))
                {
                    blip.Play();
                }
            }
            if(Key == "Bloopy") {
                DoorScr.hasBloopy = true;
                cable.ColorOn();
                if(!(DoorScr.hasBloopy && DoorScr.hasGloopy))
                {
                    blip.Play();
                }
            }  
        }
    }
    public void OnTriggerExit2D(Collider2D col) {
        Debug.Log(col);
        if(cable) {
        if(col.gameObject.name == Key + "Box" || col.gameObject.name == Key) {
            if(Key == "Gloopy") {
                DoorScr.hasGloopy = false;
                cable.ColorOff();
            }
            if(Key == "Bloopy") {
                DoorScr.hasBloopy = false;
                cable.ColorOff();
            }  
        } 
        }

    }
}

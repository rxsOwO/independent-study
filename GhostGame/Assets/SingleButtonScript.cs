using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleButtonScript : MonoBehaviour
{
    public GameObject Door;
    public SingleDoorScript DoorScr;
    public string Key;
    public LightUpCable cable;

    public AudioSource blip;
    // Start is called before the first frame update
    void Start()
    {
        DoorScr = Door.GetComponent<SingleDoorScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col) {
        Debug.Log(col);
        Debug.Log(col.gameObject.name == Key);
        if(col.gameObject.name == Key || col.gameObject.name == Key + "Box" || Key == "Default") {
                DoorScr.hasBloopy = true;
                cable.ColorOn();
        }
    }
    public void OnTriggerExit2D(Collider2D col) {
        Debug.Log(col);
        if(cable) {
        if(col.gameObject.name == Key + "Box" || col.gameObject.name == Key || Key == "Default") {
                DoorScr.hasBloopy = false;
                cable.ColorOff();
        } 
        }

    }
}

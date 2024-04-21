using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject Door; 
    public string Key;
    // Start is called before the first frame update
    void Start()
    {
        
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
                Door.GetComponent<DoorScript>().hasGloopy = true;
            }
            if(Key == "Bloopy") {
                Door.GetComponent<DoorScript>().hasBloopy = true;
            }  
        }
    }
    public void OnTriggerExit2D(Collider2D col) {
        Debug.Log(col);
        if(col.gameObject.name == Key + "Box" || col.gameObject.name == Key) {
            if(Key == "Gloopy") {
                Door.GetComponent<DoorScript>().hasGloopy = false;
            }
            if(Key == "Bloopy") {
                Door.GetComponent<DoorScript>().hasBloopy = false;
            }  
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelFlag : MonoBehaviour
{
    public string type;
    public EndLevel parent;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag(type)) {
            if(type == "Bloopy") {
                //other.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                parent.BloopyRb = other.gameObject.GetComponent<Rigidbody2D>();
            }
            else {
                //other.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                parent.GloopyRb = other.gameObject.GetComponent<Rigidbody2D>();
            }
        }
    }
}

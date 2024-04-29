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
                parent.BloopyRb = other.gameObject.GetComponent<Rigidbody2D>();
            }
            else {
                parent.GloopyRb = other.gameObject.GetComponent<Rigidbody2D>();
            }
        }
    }
}

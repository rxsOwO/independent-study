using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public Rigidbody2D BloopyRb;
    public Rigidbody2D GloopyRb;
    public string type;
    void Start()
    {
    }
    void Update() {
        /*rb.velocity = new Vector2(0,0);
        if(other.gameObject.CompareTag(type)) {
            //rb.isKinematic = true;
            gameObject.SetActive(false);
            rb.velocity = transform.right *10;
            Invoke("EndMenuActivate", 1f);
        }*/
    }
    /*
    public void EndMenuActivate() {
        PlayerPrefs.SetInt("lastSavedScene", SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("highestLevel", SceneManager.GetActiveScene().buildIndex - 1);
        rb.bodyType = RigidbodyType2D.Static;
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    private Rigidbody2D rb;
    public string type;
    void Start()
    {
        rb = GameObject.FindGameObjectWithTag(type).GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D other) {
        rb.velocity = new Vector2(0,0);
        if(other.gameObject.CompareTag(type)) {
            //rb.isKinematic = true;
            gameObject.SetActive(false);
            rb.velocity = transform.right *10;
            Invoke("EndMenuActivate", 1f);
        }
    }
    public void EndMenuActivate() {
        PlayerPrefs.SetInt("lastSavedScene", SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("highestLevel", SceneManager.GetActiveScene().buildIndex - 1);
        rb.bodyType = RigidbodyType2D.Static;
    }
}

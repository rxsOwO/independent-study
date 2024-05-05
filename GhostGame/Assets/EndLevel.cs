using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public Rigidbody2D BloopyRb;
    public Rigidbody2D GloopyRb;
    void Start()
    {
    }
    void Update() {
        if(GloopyRb && BloopyRb) {
            BloopyRb.gameObject.GetComponent<PlayerMovement>().enabled = false;
            GloopyRb.gameObject.GetComponent<PlayerMovement>().enabled = false;

            Invoke("CutScene", 1f);
        }
    }
    public void CutScene() {
        /*BloopyRb.velocity = new Vector2(0,0);
        BloopyRb.isKinematic = true;
        BloopyRb.velocity = transform.up *10;
        GloopyRb.velocity = new Vector2(0,0);
        GloopyRb.isKinematic = true;
        GloopyRb.velocity = transform.up *10;*/
        Animator BloopyAnim = BloopyRb.gameObject.GetComponent<Animator>();
        Animator GloopyAnim = GloopyRb.gameObject.GetComponent<Animator>();

        BloopyAnim.Play("Player_Death");
        GloopyAnim.Play("Player_Death");
        Invoke("EndMenuActivate", 2.5f);
    }
    public void EndMenuActivate() {
        PlayerPrefs.SetInt("lastSavedScene", SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("highestLevel", SceneManager.GetActiveScene().buildIndex - 1);
        BloopyRb.bodyType = RigidbodyType2D.Static;
        GloopyRb.bodyType = RigidbodyType2D.Static;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

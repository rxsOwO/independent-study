using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public bool active;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    void Update() 
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);
        if(Input.GetKey(KeyCode.Escape)) {
            PlayerPrefs.SetInt("lastSavedScene", SceneManager.GetActiveScene().buildIndex);
            
            if(PlayerPrefs.GetInt("highestLevel") <= SceneManager.GetActiveScene().buildIndex - 2) {
                PlayerPrefs.SetInt("highestLevel", SceneManager.GetActiveScene().buildIndex - 2);
            }
            
            SceneManager.LoadScene(0);
        }
    }
    void FixedUpdate()
    {
        if(active) {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        }
    }
}

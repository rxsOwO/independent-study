using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Reset : MonoBehaviour
{
    public int moves;
    Scene scene;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        
        text.text = moves.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(moves == 0) {
            text.color = Color.red;
        }
        if(moves <= -1) {
            SceneManager.LoadScene(scene.name);
        }
        if(Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(scene.name);
        }
    }
}

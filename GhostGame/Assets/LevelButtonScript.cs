using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelButtonScript : MonoBehaviour
{
    public int level;
    public Sprite levelImage;
    public void Start() {
        level = int.Parse(gameObject.name);
        if(PlayerPrefs.GetInt("highestLevel") >= level) {
            gameObject.GetComponent<Image>().sprite = levelImage;
        }
    }
    public void LevelSelect() {
        if(PlayerPrefs.GetInt("highestLevel") >= level) {
            SceneManager.LoadScene(gameObject.name);
        }
    }
}

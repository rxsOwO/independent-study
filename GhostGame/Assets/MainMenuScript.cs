using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void Exit() {
        Application.Quit();
    }
    public void Play() {
        if(PlayerPrefs.GetInt("lastSavedScene") <= 1) {
            PlayerPrefs.SetInt("lastSavedScene", 2);
            PlayerPrefs.SetInt("highestLevel", 0);
            SceneManager.LoadScene(2);
        }
        else {
            SceneManager.LoadScene(PlayerPrefs.GetInt("lastSavedScene"));
        }
        
    }
    public void LevelSelect() {
        SceneManager.LoadScene("LevelSelect");
    }
    public void Reset() {
        PlayerPrefs.SetInt("lastSavedScene", 2);
        PlayerPrefs.SetInt("highestLevel", 0);
    }
    public void Back() {
        SceneManager.LoadScene("Menu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject game;
    public GameObject settings;
    public GameObject credits;

    public void Play(){
        game.SetActive(true);
    }

    public void Credits(){
        credits.SetActive(true);
    }

    public void Quit(){
        Application.Quit();
    }
}

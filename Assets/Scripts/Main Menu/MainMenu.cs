using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string game;
    public string settings;
    public string credits;

    public void Play(){
        SceneManager.LoadScene(game);
    }
}

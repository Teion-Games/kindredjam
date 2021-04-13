using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas, cardsMenu;
    public bool isPaused;
    public bool isShowingCards;
    public GameObject resumeButton;
    void Start()
    {
        pauseCanvas.SetActive(false);
    }
    public bool HandlePauseandResume()
    {
        isPaused = !isPaused;
        if(isPaused) 
        {
            Pause();
        }
        else
        {
            Resume();
        }
        return isPaused;
    }

    void Pause()
    {
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
        EventSystem.current.SetSelectedGameObject(resumeButton);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
        
        foreach (PlayerInput player in FindObjectsOfType<PlayerInput>())
        {
            player.EnableControls();
        }
       
    }

    public void ShowCardsMenu()
    {
        pauseCanvas.SetActive(false);
        cardsMenu.SetActive(true);
        isShowingCards = true;
    }

    public void HideCardsMenu()
    {
        pauseCanvas.SetActive(true);
        cardsMenu.SetActive(false);
        isShowingCards = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CardsMenu : MonoBehaviour
{
    PlayerInputActions inputActions;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public Image cardImage;
    public Image cardBackground;
    public TextMeshProUGUI pageText;
    int currentCard = 0;
    public List<Card> cardList = new List<Card>();
    public Card questionMarkCard;
    int pageToShow = 1;

    void Awake()
    {
        inputActions = new PlayerInputActions();
    }

    void OnEnable()
    {
        inputActions.CardMenu.Enable();
    }

    void OnDisable()
    {
        inputActions.CardMenu.Disable();
    }


    void Update()
    {
        pageText.text = ""+pageToShow+"/10";
        if(inputActions.CardMenu.GoForward.triggered)
        {
            currentCard++;
            pageToShow++;
            if(currentCard>cardList.Count-1)
            {
                currentCard=0;
                pageToShow = 1;
            }
        }
        if(inputActions.CardMenu.GoBackwards.triggered)
        {
            currentCard--;
            pageToShow--;
            if(currentCard<0)
            {
                currentCard = cardList.Count-1;
                pageToShow = cardList.Count;
            }
        }

        if(inputActions.CardMenu.BackToMenu.triggered)
        {
            if(SceneManager.GetActiveScene().name == "Cards")
            {
                SceneManager.LoadScene("Menu");
            }
        }

        DisplayCurrentCard();
    }

    void DisplayCurrentCard()
    {
        if(PlayerPrefs.GetInt("card"+currentCard)==1)
        {
            nameText.text = cardList[currentCard].cardName;
            descriptionText.text = cardList[currentCard].description;
            cardImage.sprite = cardList[currentCard].cardImage;
            cardBackground.sprite = cardList[currentCard].cardBackground;
        }
        else
        {
            nameText.text = questionMarkCard.cardName;
            descriptionText.text = questionMarkCard.description;
            cardImage.sprite = questionMarkCard.cardImage;
            cardBackground.sprite = questionMarkCard.cardBackground;
        }
    }
}

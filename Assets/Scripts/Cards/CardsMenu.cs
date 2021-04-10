using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CardsMenu : MonoBehaviour
{
    PlayerInputActions inputActions;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public Image cardImage;
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
        DisplayCurrentCard();
    }

    void DisplayCurrentCard()
    {
        if(PlayerPrefs.GetInt("card"+currentCard)==1)
        {
            nameText.text = cardList[currentCard].cardName;
            descriptionText.text = cardList[currentCard].description;
            cardImage.sprite = cardList[currentCard].cardImage;
        }
        else
        {
            nameText.text = questionMarkCard.cardName;
            descriptionText.text = questionMarkCard.description;
            cardImage.sprite = questionMarkCard.cardImage;
        }
    }
}

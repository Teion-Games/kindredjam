using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Card", menuName = "Cards/New Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public string description;
    public Sprite cardImage;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Card", menuName = "Cards/New Card")]
public class Card : ScriptableObject
{
    public string cardName;
    [TextArea(3, 10)]
    public string description;
    public Sprite cardImage;
}

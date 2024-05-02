using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewCard", menuName ="ScriptableObject/Card")]
public class CardConfigs : ScriptableObject
{
    public int CardID;
    public CardType Type;
    public string Description;

    public void CardFunction()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour, Rules
{
    public enum Continuation
    {
        Blitz, Fumble, FiveYardRun, PassCompletion, FirstDown, EndOfQuarter1, EndOfQuarter2, EndOfQuarter3, EndOfQuarter4
    }

    public enum Defensive
    {
        Tackle, Interception, BlockedKick
    }

    public enum Offensive
    {
        Rushing, Passing, HailMary, Conversion, FieldGoal, ExtraPoint
    }

    public Card()
    {
    }

    public static List<Card> CreateCard(int numToMake, Card cardType)
    {
        List<Card> cards = new List<Card>();
        for(int i = 0; i < numToMake; i++)
        {
            cards.Add(cardType);
        }
        return cards;
    }

    public void Play()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

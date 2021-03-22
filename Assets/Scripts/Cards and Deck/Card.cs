using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> deck = new List<Card>(100); //100 cards in deck

    private void CreateDeck()
    {
        //** CONTINTUATION CARDS **//
        // ContinuationCard(string, Object)

        foreach (Card card in Card.CreateCard(8, new ContinuationCard("isBlitz", Resources.Load("blitz")))) //creates a list of a specific cards with a specified number of cards and iterates over them
        {
            deck.Add(card); //adds each card in the newly created list, to the deck
        }
        foreach (Card card in Card.CreateCard(4, new ContinuationCard("isFumble", Resources.Load("fumble")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(8, new ContinuationCard("isFiveYardRun", Resources.Load("5_yard_run")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(8, new ContinuationCard("isFirstDown", Resources.Load("first_down")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(8, new ContinuationCard("isPassCompletion", Resources.Load("pass_completion")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new ContinuationCard("isEndOfQuarter", Resources.Load("end_of_quarter1")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new ContinuationCard("isPassCompletion", Resources.Load("end_of_quarter2")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new ContinuationCard("isPassCompletion", Resources.Load("end_of_quarter3")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new ContinuationCard("isPassCompletion", Resources.Load("end_of_quarter4")))) 
        {
            deck.Add(card); 
        }

        //** DEFENSIVE CARDS **//
        // DefensiveCard(string, Object)

        foreach (Card card in Card.CreateCard(11, new DefensiveCard("isBlockedKick", Resources.Load("blocked_kick")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(4, new DefensiveCard("isTackle", Resources.Load("tackle")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(3, new DefensiveCard("isInterception", Resources.Load("interception")))) 
        {
            deck.Add(card); 
        }

        //** OFFFENSIVE CARDS **//
        // OffensiveCard(string, Object, int)

        foreach (Card card in Card.CreateCard(7, new OffensiveCard("isFieldGoal", Resources.Load("field_goal"), 3))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(6, new OffensiveCard("isConversion", Resources.Load("conversion"), 2))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new OffensiveCard("isHailMary", Resources.Load("hail_mary"), 8))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(6, new OffensiveCard("isPassing", Resources.Load("passing_td"), 6))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(6, new OffensiveCard("isRushing", Resources.Load("rushing_td"), 6))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(11, new OffensiveCard("isExtraPoint", Resources.Load("extra_point"), 1))) 
        {
            deck.Add(card); 
        }
    }

    private void ShuffleDeck()
    {
        deck = deck.OrderBy(Matrix4x4 => UnityEngine.Random.value).ToList(); //poor complexity but with only 100 items it *should* be okay
    }

    public Card DrawCard() //possibly add argument to be passed for how many cards are to be drawn
    {
        Card drawnCard = deck.First<Card>(); //copy first card in the deck
        deck.Remove(deck.First<Card>()); //remove first card from deck, this will automatically move the First call to the next card
        return drawnCard;
    }

    private void Deal()
    {
        foreach (GamePlayer player in Table.players)
        {
            for (int i = 0; i < 5; i++) //each player starts with 5 cards
            {
                player.Hand.Add(DrawCard());
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            CreateDeck();
            ShuffleDeck();
            Deal();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

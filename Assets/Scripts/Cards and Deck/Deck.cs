using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public static List<Card> deck = new List<Card>(100); //100 cards in deck
    private void CreateDeck()
    {
        //** CONTINTUATION CARDS **//
        // ContinuationCard(string, Object)

        foreach (Card card in Card.CreateCard(8, new ContinuationCard(Card.Continuation.Blitz, Resources.Load("blitz")))) //creates a list of a specific cards with a specified number of cards and iterates over them
        {
            deck.Add(card); //adds each card in the newly created list, to the deck
        }
        foreach (Card card in Card.CreateCard(4, new ContinuationCard(Card.Continuation.Fumble, Resources.Load("fumble")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(8, new ContinuationCard(Card.Continuation.FiveYardRun, Resources.Load("5_yard_run")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(8, new ContinuationCard(Card.Continuation.FirstDown, Resources.Load("first_down")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(8, new ContinuationCard(Card.Continuation.PassCompletion, Resources.Load("pass_completion")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new ContinuationCard(Card.Continuation.EndOfQuarter1, Resources.Load("end_of_quarter1")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new ContinuationCard(Card.Continuation.EndOfQuarter2, Resources.Load("end_of_quarter2")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new ContinuationCard(Card.Continuation.EndOfQuarter3, Resources.Load("end_of_quarter3")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new ContinuationCard(Card.Continuation.EndOfQuarter4, Resources.Load("end_of_quarter4")))) 
        {
            deck.Add(card); 
        }

        //** DEFENSIVE CARDS **//
        // DefensiveCard(string, Object)

        foreach (Card card in Card.CreateCard(11, new DefensiveCard(Card.Defensive.BlockedKick, Resources.Load("blocked_kick")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(4, new DefensiveCard(Card.Defensive.Tackle, Resources.Load("tackle")))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(3, new DefensiveCard(Card.Defensive.Interception, Resources.Load("interception")))) 
        {
            deck.Add(card); 
        }

        //** OFFFENSIVE CARDS **//
        // OffensiveCard(string, Object, int)

        foreach (Card card in Card.CreateCard(7, new OffensiveCard(Card.Offensive.FieldGoal, Resources.Load("field_goal"), 3))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(6, new OffensiveCard(Card.Offensive.Conversion, Resources.Load("conversion"), 2))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new OffensiveCard(Card.Offensive.HailMary, Resources.Load("hail_mary"), 8))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(6, new OffensiveCard(Card.Offensive.Passing, Resources.Load("passing_td"), 6))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(6, new OffensiveCard(Card.Offensive.Rushing, Resources.Load("rushing_td"), 6))) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(11, new OffensiveCard(Card.Offensive.ExtraPoint, Resources.Load("extra_point"), 1))) 
        {
            deck.Add(card); 
        }
    }

    private void ShuffleDeck()
    {
        deck = deck.OrderBy(Matrix4x4 => UnityEngine.Random.value).ToList(); //poor complexity but with only 100 items it *should* be okay
    }

    public static Card DrawCard() //possibly add argument to be passed for how many cards are to be drawn
    {
        // TODO: handle condition for empty deck.
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

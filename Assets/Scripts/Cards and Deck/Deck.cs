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

        foreach (Card card in Card.CreateCard(8, new Blitz())) //creates a list of a specific cards with a specified number of cards and iterates over them
        {
            deck.Add(card); //adds each card in the newly created list, to the deck
        }
        foreach (Card card in Card.CreateCard(4, new Fumble())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(8, new FiveYardRun())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(8, new FirstDown())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(8, new PassCompletion())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new EndOfQuarter1())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new EndOfQuarter2())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new EndOfQuarter3())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new EndOfQuarter4())) 
        {
            deck.Add(card); 
        }

        //** DEFENSIVE CARDS **//

        foreach (Card card in Card.CreateCard(11, new BlockedKick())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(4, new Tackle())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(3, new Interception())) 
        {
            deck.Add(card); 
        }

        //** OFFFENSIVE CARDS **//

        foreach (Card card in Card.CreateCard(7, new FieldGoal())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(6, new Conversion())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(2, new HailMary())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(6, new PassingTD())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(6, new RushingTD())) 
        {
            deck.Add(card); 
        }
        foreach (Card card in Card.CreateCard(11, new ExtraPoint())) 
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
        foreach (GamePlayer player in Table.players) // each player is given a starting hand
        {
            for (int i = 0; i < 5; i++) // each player starts with 5 cards
            {
                player.Hand.Add(DrawCard());
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsMasterClient) // ensures only one user is creating the deck
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

using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<GameObject> deck = new List<GameObject>(); //100 cards in deck
    public GameObject blitz;
    public GameObject fumble;
    public GameObject fiveYardRun;

    public Deck()
    {
        Debug.Log("Deck created");
        //CreateDeck();
        //ShuffleDeck();
    }
    public void CreateDeck()
    {
        
        Debug.Log("Creating Deck");
        //** CONTINTUATION CARDS **//
        blitz = gameObject.GetComponent<GameObject>();
        Instantiate(blitz);
        foreach (GameObject card in Card.CreateCard(8, blitz)) //creates a list of a specific cards with a specified number of cards and iterates over them
        {
            deck.Add(card); //adds each card in the newly created list, to the deck
        }
        fumble = gameObject.GetComponent<GameObject>();
        foreach (GameObject card in Card.CreateCard(4, fumble))
        {
            deck.Add(card);
        }
        fiveYardRun = gameObject.GetComponent<GameObject>();
        foreach (GameObject card in Card.CreateCard(8, fiveYardRun))
        {
            deck.Add(card);
        }
        //foreach (Card card in Card.CreateCard(8, gameObject.AddComponent<FirstDown>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card card in Card.CreateCard(8, gameObject.AddComponent<PassCompletion>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card card in Card.CreateCard(2, gameObject.AddComponent<EndOfQuarter1>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card card in Card.CreateCard(2, gameObject.AddComponent<EndOfQuarter2>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card card in Card.CreateCard(2, gameObject.AddComponent<EndOfQuarter3>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card card in Card.CreateCard(2, gameObject.AddComponent<EndOfQuarter4>())) 
        //{
        //    deck.Add(card); 
        //}

        //** DEFENSIVE CARDS **//

        //foreach (Card card in Card.CreateCard(11, gameObject.AddComponent<BlockedKick>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card card in Card.CreateCard(4, gameObject.AddComponent<Tackle>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card card in Card.CreateCard(3, gameObject.AddComponent<Interception>())) 
        //{
        //    deck.Add(card); 
        //}

        //** OFFFENSIVE CARDS **//

        //foreach (Card card in Card.CreateCard(7, gameObject.AddComponent<FieldGoal>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card card in Card.CreateCard(6, gameObject.AddComponent<Conversion>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card  card in Card.CreateCard(2, gameObject.AddComponent<HailMary>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card card in Card.CreateCard(6, gameObject.AddComponent<PassingTD>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card card in Card.CreateCard(6, gameObject.AddComponent<RushingTD>())) 
        //{
        //    deck.Add(card); 
        //}
        //foreach (Card card in Card.CreateCard(11, gameObject.AddComponent<ExtraPoint>()))
        //{
        //    deck.Add(card); 
        //}
    }

    public void ShuffleDeck()
    {
        Debug.Log("Shuffling Deck");
        deck = deck.OrderBy(Matrix4x4 => UnityEngine.Random.value).ToList(); //poor complexity but with only 100 items it *should* be okay
    }

    public GameObject DrawCard() //possibly add argument to be passed for how many cards are to be drawn
    {
        Debug.Log("Drawing card");
        // TODO: handle condition for empty deck.
        GameObject drawnCard = deck.First<GameObject>(); //copy first card in the deck
        deck.Remove(deck.First<GameObject>()); //remove first card from deck, this will automatically move the First call to the next card
        return drawnCard;
    }

    public void Deal(GamePlayer player)
    {
        Debug.Log("Dealing Cards");
        for (int i = 0; i < 5; i++) // each player starts with 5 cards
        {
            player.Hand.Add(DrawCard());
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Running start of Deck");
        Debug.Log("Deck size" + deck.Count);
        foreach (GameObject card in deck)
        {
            Debug.Log("Instantiate " + card);
            Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity);//.transform.SetParent(myHandArea.transform);
        }
        if (PhotonNetwork.IsMasterClient) // ensures only one user is creating the deck
        {
            //CreateDeck();
            //ShuffleDeck();
            
            //Deal();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

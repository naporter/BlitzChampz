using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{
    private List<GamePlayer> players = new List<GamePlayer>();
    private List<GameObject> deck = new List<GameObject>(); //100 cards in deck
    public GameObject timer; //timer for play starts at 60 seconds
    public GameObject handArea;
    public GameObject blitz;
    public GameObject fumble;
    public GameObject fiveYardRun;
    public GameObject firstDown;
    public GameObject passCompletion;
    public GameObject endOfQuarter1;
    public GameObject endOfQuarter2;
    public GameObject endOfQuarter3;
    public GameObject endOfQuarter4;
    public GameObject blockedKick;
    public GameObject tackle;
    public GameObject interception;
    public GameObject fieldGoal;
    public GameObject conversion;
    public GameObject hailMary;
    public GameObject passingTD;
    public GameObject rushingTD;
    public GameObject extraPoint;
    private float startTime;
    private readonly float TURN_TIME = 60;

    public GameObject MyHandArea { get => handArea; set => handArea = value; }
    public List<GamePlayer> Players { get => players; set => players = value; }
    public void CreateDeck()
    {
        Debug.Log("Creating Deck");
        //** CONTINTUATION CARDS **//
        foreach (GameObject card in Card.CreateCard(8, blitz)) //creates a list of a specific cards with a specified number of cards and iterates over them
        {
            deck.Add(card); //adds each card in the newly created list, to the deck
        }
        foreach (GameObject card in Card.CreateCard(4, fumble))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(8, fiveYardRun))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(8, firstDown))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(8, passCompletion))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(2, endOfQuarter1))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(2, endOfQuarter2))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(2, endOfQuarter3))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(2, endOfQuarter4))
        {
            deck.Add(card);
        }

        //**DEFENSIVE CARDS * *//

        foreach (GameObject card in Card.CreateCard(11, blockedKick))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(4, tackle))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(3, interception))
        {
            deck.Add(card);
        }

        //**OFFFENSIVE CARDS * *//

        foreach (GameObject card in Card.CreateCard(7, fieldGoal))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(6, conversion))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(2, hailMary))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(6, passingTD))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(6, rushingTD))
        {
            deck.Add(card);
        }
        foreach (GameObject card in Card.CreateCard(11, extraPoint))
        {
            deck.Add(card);
        }
    }

    public void ShuffleDeck()
    {
        Debug.Log("Shuffling Deck");
        deck = deck.OrderBy(Matrix4x4 => UnityEngine.Random.value).ToList(); //poor complexity but with only 100 items it *should* be okay
    }

    public GameObject DrawCard() //possibly add argument to be passed for how many cards are to be drawn
    {
        Debug.Log("Drawing card");
        //TODO: handle condition for empty deck.
        GameObject drawnCard = deck.First(); //copy first card in the deck
        deck.Remove(deck.First()); //remove first card from deck, this will automatically move the First call to the next card
        Debug.Log(drawnCard);
        return drawnCard;
    }

    public void Deal()
    {

        Debug.Log("Dealing Cards");
        foreach (GamePlayer player in Players)
        {
            Debug.Log("Dealing to: " + player);
            for (int i = 0; i < 5; i++) // each player starts with 5 cards
            {
                player.Hand.Add(DrawCard());
            }
            //player.ShowHand();
        }
        TestShowingHand();
    }

    public void TestShowingHand()
    {
        foreach(GameObject card in deck)
        {
            GameObject myCard = Instantiate<GameObject>(card, new Vector3(0, 0, 0), Quaternion.identity);
            myCard.transform.SetParent(handArea.transform);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        players.Add(gameObject.AddComponent<GamePlayer>());
        CreateDeck();
        ShuffleDeck();
        Deal();
        //Debug.Log("Starting Table initializations");
        //startTime = TURN_TIME;
        //if (PhotonNetwork.IsMasterClient) //ensures that only one user instantiates the player objects
        //{
        //    deck = new Deck();
        //    timer.GetComponent<Text>().text = "60";
        //    int index = 0;
        //    foreach (Player player in PhotonNetwork.PlayerList) // associate GamePlayer class with Photon Players
        //    {
        //        Debug.Log("Initialize Player: " +  player.NickName);
        //        players.Add(gameObject.AddComponent<GamePlayer>());
        //        deck.Deal(players[index]);
        //        player.TagObject = players[index];
        //        players[index].DisplayName = player.NickName;
        //        players[index].ShowHand();
        //        //foreach (Card card in players[index].Hand)
        //        //{
        //            //Debug.Log("Initialize card: " + card);
        //            //card.ShowCard();
        //        //}
        //        index++;
        //    }
        //}
        //Debug.Log("Deck size: " + deck.deck.Count);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{
    public static List<GamePlayer> players = new List<GamePlayer>(2);
    [SerializeField]
    private GameObject timer; //timer for play starts at 60 seconds
    [SerializeField]
    public GameObject myHandArea;
    [SerializeField]
    public GameObject opponentHandArea;
    private float startTime;
    private readonly float TURN_TIME = 60;

    public Deck deck;

    // Start is called before the first frame update
    void Start()
    {
        TestingBlock();
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

    void TestingBlock()
    {
        deck = gameObject.GetComponent<Deck>();
        deck.CreateDeck();
    }

    public void ShowAllCards()
    {
        //foreach (GameObject card in deck.deck)
        //{
        //    Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity);//.transform.SetParent(myHandArea.transform);
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }
}

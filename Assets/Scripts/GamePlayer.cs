using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer : Table
{
    private string displayName;
    private List<GameObject> hand = new List<GameObject>();
    private bool turn;
    private int score;

    void AddPoints(int points)
    {
        score += points;
    }

    void RemovePoints(int points)
    {
        score -= points;
    }
    public List<GameObject> Hand
    {
        get { return hand; }
    }

    public string DisplayName { get => displayName; set => displayName = value; }

    void DrawCard()
    {
        //hand.Add(Deck.DrawCard());
    }

    public void ShowHand()
    {
        Debug.Log("Cards in hand: " + hand.Count);
        foreach (GameObject card in this.hand)
        {
            Debug.Log("host " + card);
            Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(MyHandArea.transform, false);
        }

    }

    void PlayCard(GameObject card)
    {
        //hand.Remove(card);
        //card.Play();
        //ChangeTurn();
    }

    void ChangeTurn()
    {
        this.turn = !turn;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update Running for Hand in GamePlayer");
        //foreach(GameObject card in hand)
        //{
        //    Instantiate(card, new Vector3(0,0,0), Quaternion.identity).transform.SetParent(MyHandArea.transform);
        //}
    }
}

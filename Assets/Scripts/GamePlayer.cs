using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer : MonoBehaviour
{
    private List<Card> hand = new List<Card>();
    private bool turn;

    public List<Card> Hand
    {
        get { return hand; }
    }

    void DrawCard()
    {
        hand.Add(Deck.DrawCard());
    }

    void PlayCard()
    {

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
        
    }
}

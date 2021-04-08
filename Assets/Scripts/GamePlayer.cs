using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer : MonoBehaviour
{
    private List<Card> hand = new List<Card>();
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
    public List<Card> Hand
    {
        get { return hand; }
    }

    void DrawCard()
    {
        hand.Add(Deck.DrawCard());
    }

    void PlayCard(Card card)
    {
        hand.Remove(card);
        card.Play();
        ChangeTurn();
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

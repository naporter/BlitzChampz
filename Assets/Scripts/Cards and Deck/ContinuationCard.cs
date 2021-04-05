using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinuationCard : Card, Rules
{

    private Continuation cardType;
    private Object cardImage;

    public ContinuationCard(Continuation cardType, Object cardImage)
    {
        this.cardType = cardType;
        this.cardImage = cardImage;
    }

    void Rules.OnPlay()
    {
        if (cardType.Equals(Card.Continuation.Blitz))
        {
            //do these functions
        }
        Debug.Log(cardType);
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

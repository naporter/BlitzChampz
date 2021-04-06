using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinuationCard : Card
{

    private Continuation cardType;
    private Object cardImage;

    public ContinuationCard(Continuation cardType, Object cardImage)
    {
        this.cardType = cardType;
        this.cardImage = cardImage;
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

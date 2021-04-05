using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefensiveCard : Card
{
    private Defensive cardType;
    private Object cardImage;

    public DefensiveCard(Defensive cardType, Object cardImage)
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

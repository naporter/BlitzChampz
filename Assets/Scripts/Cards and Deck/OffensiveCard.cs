using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffensiveCard : Card
{
    private Offensive cardType;
    private int numPoints;
    private Object cardImage;

    public OffensiveCard(Offensive cardType, Object cardImage, int numPoints)
    {
        this.cardType = cardType;
        this.cardImage = cardImage;
        this.numPoints = numPoints;
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

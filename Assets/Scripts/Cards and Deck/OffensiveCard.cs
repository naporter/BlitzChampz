using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffensiveCard : Card
{
    private bool isRushing;
    private bool isPassing;
    private bool isHailMary;
    private bool isConversion;
    private bool isFieldGoal;
    private bool isExtraPoint;
    private int numPoints;
    private Object cardImage;

    public OffensiveCard(string cardType, Object cardImage, int numPoints)
    {
        switch (cardType)
        {
            case "isRushing":
                this.isRushing = true;
                break;
            case "isPassing":
                this.isPassing = true;
                break;
            case "isHailMary":
                this.isHailMary = true;
                break;
            case "isConversion":
                this.isConversion = true;
                break;
            case "isFieldGoal":
                this.isFieldGoal = true;
                break;
            case "isExtraPoint":
                this.isExtraPoint = true;
                break;
        }
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

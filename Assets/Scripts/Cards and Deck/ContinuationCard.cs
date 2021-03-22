using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinuationCard : Card
{

    private bool isPassCompletion;
    private bool isFirstDown;
    private bool isFiveYardRun;
    private bool isBlitz;
    private bool isFumble;
    private bool isEndOfQuarter;
    private Object cardImage;

    public ContinuationCard(string cardType, Object cardImage)
    {
        switch (cardType)
        {
            case "isPassCompletion":
                this.isPassCompletion = true;
                break;
            case "isFirstDown":
                this.isFirstDown = true;
                break;
            case "isFiveYardRun":
                this.isFiveYardRun = true;
                break;
            case "isBlitz":
                this.isBlitz = true;
                break;
            case "isFumble":
                this.isFumble = true;
                break;
            case "isEndOfQuarter":
                this.isEndOfQuarter = true;
                break;
        }
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

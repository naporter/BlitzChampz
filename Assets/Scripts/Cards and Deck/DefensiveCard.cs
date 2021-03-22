using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefensiveCard : Card
{

    private bool isTackle;
    private bool isInterception;
    private bool isBlockedKick;
    private Object cardImage;

    public DefensiveCard(string cardType, Object cardImage)
    {
        switch(cardType){
            case "isTackle":
                this.isTackle = true;
                break;
            case "isInterception":
                this.isInterception = true;
                break;
            case "isBlockedKick":
                this.isBlockedKick = true;
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

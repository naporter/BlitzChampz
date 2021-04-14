using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{

    public Card()
    {
    }

    public static List<GameObject> CreateCard(int numToMake, GameObject cardType)
    {
        List<GameObject> cards = new List<GameObject>();
        for(int i = 0; i < numToMake; i++)
        {
            cards.Add(cardType);
        }
        return cards;
    }

    public void Play()
    {
    }

    public virtual GameObject GetPrefab()
    {
        Debug.Log("Returning null type for prefab");
        return null;
    }

    public virtual void ShowCard() { }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

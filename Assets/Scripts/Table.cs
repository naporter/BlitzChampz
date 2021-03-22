using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    public static List<GamePlayer> players = new List<GamePlayer>(2);
    private int timer = 60; //timer for play starts at 60 seconds

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            //TODO: associate GamePlayer class with Photon Players
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

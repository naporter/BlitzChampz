using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{
    public static List<GamePlayer> players = new List<GamePlayer>(2);
    [SerializeField]
    private GameObject timer; //timer for play starts at 60 seconds
    [SerializeField]
    private GameObject handArea;
    private float startTime;
    private readonly float TURN_TIME = 60;

    // Start is called before the first frame update
    void Start()
    {
        startTime = TURN_TIME;
        if (PhotonNetwork.IsMasterClient) //ensures that only one user instantiates the player objects
        {
            timer.GetComponent<Text>().text = "60";
            
            int index = 0;
            foreach (Player player in PhotonNetwork.PlayerList) // associate GamePlayer class with Photon Players
            {
                player.TagObject = players[index];
                index++;
                foreach (Card card in players[index].Hand)
                {
                    
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

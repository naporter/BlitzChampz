using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickPlayController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject joinRandomLobbyButton;
    [SerializeField]
    private GameObject cancelLobbySearchButton;
    [SerializeField]
    private GameObject userMessage;
    [SerializeField]
    private int numPlayers;
    // private string userMessage;
    readonly int MAX_ROOM_VALUE = 10000;

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        joinRandomLobbyButton.SetActive(true);
    }

    public void QuickPlay()
    {
        joinRandomLobbyButton.SetActive(false);
        cancelLobbySearchButton.SetActive(true);
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("Quick Play");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("No rooms available...");
        // userMessage = "No rooms available...";
        // userMessage.SetText("No rooms available...");
        CreateLobby();
    }

    void CreateLobby() //create your own lobby
    {
        Debug.Log("Creating a new Lobby");
        // userMessage = "Creating a new Lobby";
        int randomRoomNumber = Random.Range(0, MAX_ROOM_VALUE); //initialize a random room number
        RoomOptions roomOps = new RoomOptions(){ IsVisible = true, IsOpen = true, MaxPlayers = (byte)numPlayers};
        PhotonNetwork.CreateRoom("Room" + randomRoomNumber, roomOps);
        Debug.Log(randomRoomNumber);
    }

    public override void OnCreateRoomFailed(short returnCode, string message) //called if a lobby name is taken
    {
        Debug.Log("Failed to create lobby... trying again\n" + message);
        // userMessage = "Failed to create lobby... trying again.";
        CreateLobby(); //looping this call until a random room name is not already taken
    }

    public void CancelLobbySearch() //cancel room search
    { 
        cancelLobbySearchButton.SetActive(false);
        joinRandomLobbyButton.SetActive(true);
        PhotonNetwork.LeaveRoom();
    }

    void Start() // Start is called before the first frame update
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

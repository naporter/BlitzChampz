using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class QuickPlayController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject joinRandomLobbyButton;
    [SerializeField]
    private GameObject cancelLobbySearchButton;
    [SerializeField]
    private Text userMessage;
    [SerializeField]
    private int numPlayers;
    readonly int MAX_ROOM_VALUE = 10000;

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        joinRandomLobbyButton.SetActive(true);
    }

    public void QuickPlay()
    {
        userMessage.text = userMessage.text + "Searching available rooms...";
        joinRandomLobbyButton.SetActive(false);
        cancelLobbySearchButton.SetActive(true);
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("Quick Play");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        userMessage.text = userMessage.text + "\nNo rooms available";
        Debug.Log("No rooms available...");
        CreateLobby();
    }

    public override void OnJoinedRoom()
    {
        userMessage.text = "Lobby joined! Room: " + PhotonNetwork.CurrentRoom.Name;
        base.OnJoinedRoom();
    }

    void CreateLobby() //create your own lobby
    {
        Debug.Log("Creating a new Lobby");
        userMessage.text = userMessage.text + "\nCreating a new Lobby";
        int randomRoomNumber = Random.Range(0, MAX_ROOM_VALUE); //initialize a random room number
        RoomOptions roomOps = new RoomOptions(){ IsVisible = true, IsOpen = true, MaxPlayers = (byte)numPlayers};
        PhotonNetwork.CreateRoom(randomRoomNumber.ToString(), roomOps);
        Debug.Log(randomRoomNumber);
        userMessage.text = userMessage.text + "\nJoined Room: " + randomRoomNumber;
    }

    public override void OnCreateRoomFailed(short returnCode, string message) //called if a lobby name is taken
    {
        Debug.Log("Failed to create lobby... trying again\n" + message);
        userMessage.text = userMessage.text + "\nFailed to create lobby... trying again\n" + message;
        CreateLobby(); //looping this call until a random room name is not already taken
    }

    public void CancelLobbySearch() //cancel room search
    { 
        userMessage.text = "";
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

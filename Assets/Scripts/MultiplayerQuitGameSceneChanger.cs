using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerQuitGameSceneChanger : MonoBehaviour
{

    public void Onclick()
    {
        SceneManager.LoadScene("Main Menu");
    }


}

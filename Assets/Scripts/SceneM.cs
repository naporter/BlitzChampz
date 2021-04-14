using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneM : MonoBehaviour
{
    //Switches the scene to the Main Menu
    public void Change (string level)
    {
        SceneManager.LoadScene(level);
    }
}

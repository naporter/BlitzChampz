using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassingTD : Card, Rules
{
    [SerializeField]
    private GameObject passingTDPrefab;
    private readonly int points = 6;

    public PassingTD()
    {
        passingTDPrefab = Resources.Load<GameObject>("Prefabs/PassingTD");
    }

    public new void ShowCard()
    {
        GameObject passingTD = Instantiate(passingTDPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public new void Play()
    {

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

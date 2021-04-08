using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RushingTD : Card, Rules
{
    [SerializeField]
    private GameObject rushingTDPrefab;
    private readonly int points = 6;

    public RushingTD()
    {
        rushingTDPrefab = Resources.Load<GameObject>("Prefabs/RushingTD");
    }

    public new void ShowCard()
    {
        GameObject rushingTD = Instantiate(rushingTDPrefab, new Vector3(0, 0, 0), Quaternion.identity);
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

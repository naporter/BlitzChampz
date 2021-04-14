using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RushingTD : Card
{
    [SerializeField]
    private GameObject rushingTDPrefab;
    private readonly int points = 6;

    public RushingTD()
    {
        
    }

    public new void ShowCard()
    {
        //Instantiate(rushingTDPrefab, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(handArea.transform, false);
    }

    public new void Play()
    {

    }

    public override GameObject GetPrefab()
    {
        return rushingTDPrefab;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        rushingTDPrefab = Resources.Load<GameObject>("Prefabs/RushingTD");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

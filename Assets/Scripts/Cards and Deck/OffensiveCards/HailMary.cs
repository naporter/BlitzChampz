using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailMary : Card, Rules
{
    [SerializeField]
    private GameObject hailMaryPrefab;
    private readonly int points = 8;

    public HailMary()
    {
        hailMaryPrefab = Resources.Load<GameObject>("Prefabs/HailMary");
    }

    public new void ShowCard()
    {
        GameObject hailMary = Instantiate(hailMaryPrefab, new Vector3(0, 0, 0), Quaternion.identity);
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

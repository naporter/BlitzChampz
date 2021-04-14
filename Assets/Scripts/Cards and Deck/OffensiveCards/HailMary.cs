using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailMary : Card
{
    [SerializeField]
    private GameObject hailMaryPrefab;
    private readonly int points = 8;

    public HailMary()
    {
    }

    public override void ShowCard()
    {
        //Instantiate(hailMaryPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public new void Play()
    {

    }
    public override GameObject GetPrefab()
    {
        return hailMaryPrefab;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        hailMaryPrefab = Resources.Load<GameObject>("Prefabs/HailMary");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

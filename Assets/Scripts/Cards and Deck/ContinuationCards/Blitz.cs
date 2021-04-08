using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blitz : Card, Rules
{
    [SerializeField]
    private GameObject blitzPrefab;

    public Blitz()
    {
        blitzPrefab = Resources.Load<GameObject>("Prefabs/Blitz");
    }

    public new void ShowCard()
    {
        GameObject blitz = Instantiate(blitzPrefab, new Vector3(0, 0, 0), Quaternion.identity);
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

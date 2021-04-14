using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blitz : Card
{
    [SerializeField]
    private GameObject blitzPrefab;

    public GameObject BlitzPrefab { get => blitzPrefab; set => blitzPrefab = value; }

    public Blitz()
    {
        Debug.Log("Blitz created");
        //blitzPrefab = Resources.Load<GameObject>("Prefabs/Blitz");
    }

    public override void ShowCard()
    {
       // Instantiate(blitzPrefab, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(handArea.transform, false);
    }

    public new void Play()
    {
        
    }

    public override GameObject GetPrefab()
    {
        return blitzPrefab;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Calling Start in Blitz");
        this.blitzPrefab = Resources.Load("Blitz") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfQuarter1 : Card, Rules
{
    [SerializeField]
    private GameObject endOfQuarter1Prefab;

    public EndOfQuarter1()
    {
        endOfQuarter1Prefab = Resources.Load<GameObject>("Prefabs/EndOfQuarter1");
    }

    public new void ShowCard()
    {
        GameObject endOfQuarter1 = Instantiate(endOfQuarter1Prefab, new Vector3(0, 0, 0), Quaternion.identity);
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

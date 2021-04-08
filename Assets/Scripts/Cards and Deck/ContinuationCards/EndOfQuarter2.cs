using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfQuarter2 : Card, Rules
{
    [SerializeField]
    private GameObject endOfQuarter2Prefab;

    public EndOfQuarter2()
    {
        endOfQuarter2Prefab = Resources.Load<GameObject>("Prefabs/EndOfQuarter2");
    }

    public new void ShowCard()
    {
        GameObject endOfQuarter2 = Instantiate(endOfQuarter2Prefab, new Vector3(0, 0, 0), Quaternion.identity);
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

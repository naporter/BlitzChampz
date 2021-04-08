using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfQuarter3 : Card, Rules
{
    [SerializeField]
    private GameObject endOfQuarter3Prefab;

    public EndOfQuarter3()
    {
        endOfQuarter3Prefab = Resources.Load<GameObject>("Prefabs/EndOfQuarter3");
    }

    public new void ShowCard()
    {
        GameObject endOfQuarter3 = Instantiate(endOfQuarter3Prefab, new Vector3(0, 0, 0), Quaternion.identity);
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

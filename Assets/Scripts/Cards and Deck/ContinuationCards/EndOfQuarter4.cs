using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfQuarter4 : Card, Rules
{
    [SerializeField]
    private GameObject endOfQuarter4Prefab;

    public EndOfQuarter4()
    {
        endOfQuarter4Prefab = Resources.Load<GameObject>("Prefabs/EndOfQuarter4");
    }
    public new void ShowCard()
    {
        GameObject endOfQuarter4 = Instantiate(endOfQuarter4Prefab, new Vector3(0, 0, 0), Quaternion.identity);
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

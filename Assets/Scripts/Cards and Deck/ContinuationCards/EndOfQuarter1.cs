using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfQuarter1 : Card
{
    [SerializeField]
    private GameObject endOfQuarter1Prefab;

    public EndOfQuarter1()
    {
        
    }

    public override void ShowCard()
    {
        //Instantiate(endOfQuarter1Prefab, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(handArea.transform, false);
    }

    public new void Play()
    {

    }

    public override GameObject GetPrefab()
    {
        return endOfQuarter1Prefab;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        endOfQuarter1Prefab = Resources.Load<GameObject>("Prefabs/EndOfQuarter1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

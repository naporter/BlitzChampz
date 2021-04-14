using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfQuarter4 : Card
{
    [SerializeField]
    private GameObject endOfQuarter4Prefab;

    public EndOfQuarter4()
    {
        
    }
    public override void ShowCard()
    {
        Debug.Log("Show Card");
        //Instantiate(endOfQuarter4Prefab, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(handArea.transform, false);
    }

    public new void Play()
    {

    }

    public override GameObject GetPrefab()
    {
        return endOfQuarter4Prefab;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        endOfQuarter4Prefab = Resources.Load<GameObject>("Prefabs/EndOfQuarter4");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

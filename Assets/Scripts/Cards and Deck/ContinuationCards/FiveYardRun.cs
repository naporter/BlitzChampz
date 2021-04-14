using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveYardRun : Card
{
    [SerializeField]
    private GameObject fiveYardRunPrefab;

    public FiveYardRun()
    {
        Debug.Log("FiveYardRun created");
        //fiveYardRunPrefab = Resources.Load<GameObject>("Prefabs/FiveYardRun");
    }

    public override void ShowCard()
    {
        Debug.Log("Show Card");
        //Instantiate(fiveYardRunPrefab, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(handArea.transform, false);
    }

    public new void Play()
    {

    }

    public override GameObject GetPrefab()
    {
        return fiveYardRunPrefab;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Calling Start in FiveYardRun");
        //this.fiveYardRunPrefab = Resources.Load("Prefabs/FiveYardRun") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

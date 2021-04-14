using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fumble : Card
{
    [SerializeField]
    private GameObject fumblePrefab;

    public Fumble()
    {
        Debug.Log("Fumble created");
        //fumblePrefab = Resources.Load<GameObject>("Prefabs/Fumble");
    }

    public override void ShowCard()
    {
        Debug.Log("Show Card");
        //Instantiate(fumblePrefab, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(handArea.transform, false);
    }

    public override GameObject GetPrefab()
    {
        return fumblePrefab;
    }

    public new void Play()
    {

    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Calling Start in Fumble");
        //this.fumblePrefab = Resources.Load<GameObject>("Prefabs/Fumble");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

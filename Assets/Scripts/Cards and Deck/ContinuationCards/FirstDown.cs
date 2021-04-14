using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDown : Card
{
    [SerializeField]
    private GameObject firstDownPrefab;

    public FirstDown()
    {
        
    }

    public override void ShowCard()
    {
        Debug.Log("Show Card");
        //Instantiate(firstDownPrefab, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(handArea.transform, false);
    }

    public new void Play()
    {

    }

    public override GameObject GetPrefab()
    {
        return firstDownPrefab;
    }
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        firstDownPrefab = Resources.Load<GameObject>("Prefabs/FirstDown");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

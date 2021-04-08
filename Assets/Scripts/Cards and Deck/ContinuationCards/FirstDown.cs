using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDown : Card, Rules
{
    [SerializeField]
    private GameObject firstDownPrefab;

    public FirstDown()
    {
        firstDownPrefab = Resources.Load<GameObject>("Prefabs/FirstDown");
    }

    public new void ShowCard()
    {
        GameObject firstDown = Instantiate(firstDownPrefab, new Vector3(0, 0, 0), Quaternion.identity);
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

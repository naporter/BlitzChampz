using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fumble : Card, Rules
{
    [SerializeField]
    private GameObject fumblePrefab;

    public Fumble()
    {
        fumblePrefab = Resources.Load<GameObject>("Prefabs/Fumble");
    }

    public new void ShowCard()
    {
        GameObject fumble = Instantiate(fumblePrefab, new Vector3(0, 0, 0), Quaternion.identity);
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

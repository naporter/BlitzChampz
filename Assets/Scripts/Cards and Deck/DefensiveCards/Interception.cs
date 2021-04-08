using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interception : Card, Rules
{
    [SerializeField]
    private GameObject interceptionPrefab;

    public Interception()
    {
        interceptionPrefab = Resources.Load<GameObject>("Prefabs/Interception");
    }

    public new void ShowCard()
    {
        GameObject interception = Instantiate(interceptionPrefab, new Vector3(0, 0, 0), Quaternion.identity);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interception : Card
{
    [SerializeField]
    private GameObject interceptionPrefab;

    public Interception()
    {
    }

    public new void ShowCard()
    {
       // Instantiate(interceptionPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public new void Play()
    {

    }

    public override GameObject GetPrefab()
    {
        return interceptionPrefab;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        interceptionPrefab = Resources.Load<GameObject>("Prefabs/Interception");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

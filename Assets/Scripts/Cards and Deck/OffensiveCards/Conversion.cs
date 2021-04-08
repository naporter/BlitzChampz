using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversion : Card, Rules
{
    [SerializeField]
    private GameObject conversionPrefab;
    private readonly int points = 2;

    public Conversion()
    {
        conversionPrefab = Resources.Load<GameObject>("Prefabs/Conversion");
    }

    public new void ShowCard()
    {
        GameObject conversion = Instantiate(conversionPrefab, new Vector3(0, 0, 0), Quaternion.identity);
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

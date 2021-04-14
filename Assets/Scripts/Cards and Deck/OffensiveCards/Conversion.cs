using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversion : Card
{
    [SerializeField]
    private GameObject conversionPrefab;
    private readonly int points = 2;

    public Conversion()
    {
    }

    public new void ShowCard()
    {
        //Instantiate(conversionPrefab, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(handArea.transform, false);
        //conversion.transform.SetParent(handArea.transform, false);
    }

    public new void Play()
    {

    }

    public override GameObject GetPrefab()
    {
        return conversionPrefab;
    }

    // Start is called before the first frame update
    void Start()
    {
        conversionPrefab = Resources.Load<GameObject>("Prefabs/Conversion");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

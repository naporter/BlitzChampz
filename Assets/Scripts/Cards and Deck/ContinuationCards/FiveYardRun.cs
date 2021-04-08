using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveYardRun : Card, Rules
{
    [SerializeField]
    private GameObject fiveYardRunPrefab;

    public FiveYardRun()
    {
        fiveYardRunPrefab = Resources.Load<GameObject>("Prefabs/FiveYardRun");
    }

    public new void ShowCard()
    {
        GameObject fiveYardRun = Instantiate(fiveYardRunPrefab, new Vector3(0, 0, 0), Quaternion.identity);
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

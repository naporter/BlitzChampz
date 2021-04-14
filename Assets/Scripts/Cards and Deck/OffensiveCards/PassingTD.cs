using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassingTD : Card
{
    [SerializeField]
    private GameObject passingTDPrefab;
    private readonly int points = 6;

    public PassingTD()
    {
    }

    public override void ShowCard()
    {
        //GameObject passingTD = Instantiate(passingTDPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public new void Play()
    {

    }
    public override GameObject GetPrefab()
    {
        return passingTDPrefab;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        passingTDPrefab = Resources.Load<GameObject>("Prefabs/PassingTD");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

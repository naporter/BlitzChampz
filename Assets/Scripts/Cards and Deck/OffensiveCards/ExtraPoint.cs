using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraPoint : Card, Rules
{
    [SerializeField]
    private GameObject extraPointPrefab;
    private readonly int points = 1;

    public ExtraPoint()
    {
        extraPointPrefab = Resources.Load<GameObject>("Prefabs/ExtraPoint");
    }

    public new void ShowCard()
    {
        GameObject extraPoint = Instantiate(extraPointPrefab, new Vector3(0, 0, 0), Quaternion.identity);
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

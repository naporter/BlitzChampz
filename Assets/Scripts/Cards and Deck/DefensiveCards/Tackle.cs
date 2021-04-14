using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tackle : Card, Rules
{
    [SerializeField]
    private GameObject tacklePrefab;

    public Tackle()
    {
    }

    public new void ShowCard()
    {
        //GameObject tackle = Instantiate(tacklePrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public new void Play()
    {

    }

    public override GameObject GetPrefab()
    {
        return tacklePrefab;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        tacklePrefab = Resources.Load<GameObject>("Prefabs/Tackle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

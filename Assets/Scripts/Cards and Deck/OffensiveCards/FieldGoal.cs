using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGoal : Card
{
    [SerializeField]
    private GameObject fieldGoalPrefab;
    private readonly int points = 3;

    public FieldGoal()
    {
    }

    public new void ShowCard()
    {
        //GameObject fieldGoal = Instantiate(fieldGoalPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public new void Play()
    {

    }
    public override GameObject GetPrefab()
    {
        return fieldGoalPrefab;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        fieldGoalPrefab = Resources.Load<GameObject>("Prefabs/FieldGoal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassCompletion : Card, Rules
{
    [SerializeField]
    private GameObject passCompletionPrefab;

    public PassCompletion()
    {
        passCompletionPrefab = Resources.Load<GameObject>("Prefabs/PassCompletion");
    }

    public new void ShowCard()
    {
        GameObject passCompletion = Instantiate(passCompletionPrefab, new Vector3(0, 0, 0), Quaternion.identity);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassCompletion : Card
{

    public PassCompletion()
    {
        
    }

    public override void ShowCard()
    {
        Debug.Log("Show Card");
       // Instantiate(passCompletionPrefab, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(handArea.transform, false);
    }

    public new void Play()
    {

    }
    private void Awake()
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

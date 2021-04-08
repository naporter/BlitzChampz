using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockedKick : Card, Rules
{
    [SerializeField]
    private GameObject blockedKickPrefab;

    public BlockedKick()
    {
        blockedKickPrefab = Resources.Load<GameObject>("Prefabs/BlockedKick");
    }

    public new void ShowCard()
    {
        GameObject blockedKick = Instantiate(blockedKickPrefab, new Vector3(0, 0, 0), Quaternion.identity);
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

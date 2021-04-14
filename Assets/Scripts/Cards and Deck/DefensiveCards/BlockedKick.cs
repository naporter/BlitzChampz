using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockedKick : Card
{
    [SerializeField]
    private GameObject blockedKickPrefab;

    public BlockedKick()
    {
    }

    public override void ShowCard()
    {
        //Instantiate(blockedKickPrefab, new Vector3(0, 0, 0), Quaternion.identity).transform.SetParent(handArea.transform, false);
    }

    public new void Play()
    {

    }

    public override GameObject GetPrefab()
    {
        return blockedKickPrefab;
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        blockedKickPrefab = Resources.Load<GameObject>("Prefabs/BlockedKick");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

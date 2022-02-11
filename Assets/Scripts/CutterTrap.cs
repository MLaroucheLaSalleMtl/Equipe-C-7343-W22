using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutterTrap : MonoBehaviour
{
    GameObject cutterTrapBase;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CutterHit(other);
            Destroy(cutterTrapBase);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        cutterTrapBase = GameObject.Find("Pf_Trap_Cutter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CutterHit(Collider Character)
    {
        PlayerBehavior player = Character.GetComponent<PlayerBehavior>();

        player.Live--;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrap : MonoBehaviour
{
    GameObject FireTrapBase;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CharacterHit(other);
            Destroy(FireTrapBase);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        FireTrapBase = GameObject.Find("Pf_Trap_Fire");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CharacterHit(Collider Character)
    {
        PlayerBehavior player = Character.GetComponent<PlayerBehavior>();
        player.Live--;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// programmer  100 % par Nabil
public class FireTrap : MonoBehaviour
{
    GameObject FireTrapBase;
    public bool hit = false;
    [SerializeField] private float Speed = 2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
          StartCoroutine(CharacterHit(other));
       
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


   IEnumerator CharacterHit(Collider Character)
    {
        LiveCounter player = Character.GetComponent<LiveCounter>();
        PlayerMovement player2 = Character.GetComponent<PlayerMovement>();
        if(hit == false)
        {
            player.Live--;
            player2.forwardSpeed /= Speed;
            hit = true;
        }

        yield return new WaitForSeconds(1);
        player2.forwardSpeed *= Speed;
        gameObject.SetActive(false);

       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// programmer  100 % par Nabil
public class CutterTrap : MonoBehaviour
{
    GameObject cutterTrapBase;
    public bool cuttertraphit = false;
    [SerializeField] private float Speed = 2;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           StartCoroutine(CutterHit(other));
         
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

    IEnumerator CutterHit(Collider Character)
    {
    
        LiveCounter player = Character.GetComponent<LiveCounter>();
        PlayerMovement player2 = Character.GetComponent<PlayerMovement>();
        if (cuttertraphit == false)
        {
            player.Live--;
            player2.forwardSpeed /= Speed;
            cuttertraphit = true;
        }

        yield return new WaitForSeconds(1);

        player2.forwardSpeed *= Speed;
        gameObject.SetActive(false);

       
    }
}

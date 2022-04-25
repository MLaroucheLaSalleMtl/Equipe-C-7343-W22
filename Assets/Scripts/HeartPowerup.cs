using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// programmer  100 % par Nabil
public class HeartPowerup : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        LiveCounter player = other.GetComponent<LiveCounter>();

        if (other.CompareTag("Player") && player.Live < 3)
        {
            Debug.Log(player.Live);
            player.Live++;
          
            //healthPickedUp(other);
          // Destroy(gameObject);
            Debug.Log(player.Live);
        }
       
    }




  /*  public void healthPickedUp(Collider Character)
    {
     LiveCounter  player = Character.GetComponent<LiveCounter>();

        if (player.Live < 3)
        {

            player.Live = player.Live + 1;

        }
        

    }*/



}

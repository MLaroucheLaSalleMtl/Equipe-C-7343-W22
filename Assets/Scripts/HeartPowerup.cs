using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPowerup : MonoBehaviour
{
  

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            healthPickedUp(other);
            Destroy(gameObject);
        }
    }



    public void healthPickedUp(Collider Character)
    {
     PlayerBehavior   player = Character.GetComponent<PlayerBehavior>();
   
       
       if(player.Live < 3)
        {
            player.Live++;
        }

    }



}

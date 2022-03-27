using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{

   
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }

        if(other.CompareTag("FireBall") || other.CompareTag("IceBall"))
        {

            Destroy(gameObject.transform.parent.gameObject);
         
        }



      
    }
}

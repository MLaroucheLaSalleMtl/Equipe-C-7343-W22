using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Source : https://www.youtube.com/watch?v=CLSiRf_OrBk&ab_channel=Brackeys
// programmer  100 % par Nabil
public class RocketPowerUp : MonoBehaviour
{
  [SerializeField]  public float powerupTime = 5f;
  [SerializeField]  public float multiplier = 2.00f;
    public  bool isRocketPickedUp = false;
    private bool isRockettriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        { 
            
             StartCoroutine(Boost(other));
                           
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  IEnumerator Boost(Collider Character)
    {
        PlayerMovement PlayerBoosted = Character.GetComponent<PlayerMovement>();
        if (isRockettriggered != true)
        {
            isRocketPickedUp = true;
           
            PlayerBoosted.forwardSpeed *= multiplier;
            isRockettriggered = true;
        }
        yield return new WaitForSeconds(5);


        PlayerBoosted.forwardSpeed /= multiplier;
        Destroy(gameObject);





    }
}

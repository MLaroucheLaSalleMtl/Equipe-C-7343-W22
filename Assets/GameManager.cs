using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class GameManager : MonoBehaviour
{

    private bool hit = false;


    private void Awake()
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

 /* public IEnumerator  Trappedplayer(Collider Character)
    {
        
        PlayerBehavior player = Character.GetComponent<PlayerBehavior>();
        PlayerMovement player2 = Character.GetComponent<PlayerMovement>();
        if (hit == false)
        {
            player.Live--;
            player2.forwardSpeed /= 2;
            hit = true;
        }



        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
        player2.forwardSpeed *= 2;




    }*/
}

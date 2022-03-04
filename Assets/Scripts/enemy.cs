using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 1;
    public float Hp = 3;

    private void FixedUpdate()
    {
        if(speed < 1)
        {
            StartCoroutine(ReturnBaseSpeed());
        }
    }
    public void  IceBallHit()
    {
       
            Debug.Log("iceBall has hit!");
            speed /= 2;
         
        
       
    }

    public void FireBallHit()
    {
        Hp -= 1;
    }


    public IEnumerator ReturnBaseSpeed()
    {
        yield return new WaitForSeconds(5f);
                   
        speed = 1;

    }
}

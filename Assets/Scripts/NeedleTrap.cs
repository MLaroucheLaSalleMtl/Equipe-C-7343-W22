using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// programmer  100 % par Nabil
public class NeedleTrap : MonoBehaviour
{
    public float force = -2000f;
    public float Normalspeed = 1f;
    private bool hit = false;
    [SerializeField] private float Speed = 2;
    GameManager trap;




    private void OnTriggerEnter(Collider other)
    {
       
        if(other.CompareTag("Player"))
        {
            Debug.Log("Hit");
            StartCoroutine(Trappedplayer(other));

           //StartCoroutine(trap.Trappedplayer(other));

           
            
           
        }
        if(other.CompareTag("IceBall") || other.CompareTag("FireBall"))
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       trap = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Trappedplayer(Collider Character)
    {
      LiveCounter player = Character.GetComponent<LiveCounter>();
        PlayerMovement player2 = Character.GetComponent<PlayerMovement>();
        if (hit == false)
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

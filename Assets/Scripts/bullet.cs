using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// sources : https://www.youtube.com/watch?v=Nke5JKPiQTw&t=703s&ab_channel=CodeMonkey , Marc-André Larouche
// programmer  100 % par Nabil
public class bullet : MonoBehaviour
{
    Rigidbody rb;
    GameObject OtherPlayer;
    [SerializeField] float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        OtherPlayer = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && gameObject.CompareTag("IceBall"))
        {
            Debug.Log("you hit the player!");
            enemy Enemy = other.transform.GetComponent<enemy>();
            Enemy.IceBallHit();
            Destroy(gameObject);
           
        }
        else if(other.CompareTag("Player") && gameObject.CompareTag("FireBall"))
        {

            Debug.Log("you hit the player!");
            enemy Enemy = other.transform.GetComponent<enemy>();
            Enemy.FireBallHit();
            Destroy(gameObject);
        }

       
        if(other.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
       
        
    }

  


    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.up * speed);
       

        Destroy(gameObject, 5f);
    }
}

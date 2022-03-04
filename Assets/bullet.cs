using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody rb;
    GameObject OtherPlayer;
    [SerializeField] float speed = 50f;
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

        
    }
    

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * speed);

        Destroy(gameObject, 5f);
    }
}

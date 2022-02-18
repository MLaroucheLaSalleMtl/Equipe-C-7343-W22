using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] public int Live = 3;
    [SerializeField] public Rigidbody rb;
    private float force = -100f;
    private bool hit = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Trap"))
        {
           Pushedback();
        }
    }

    public void Pushedback()
    {
        if(hit == false)
        {
            rb.AddForce(transform.forward * force, ForceMode.Impulse);
            hit = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
    }
}

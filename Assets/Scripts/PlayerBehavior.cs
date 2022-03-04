using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] public int Live = 3;
    [SerializeField] public Rigidbody rb;
    [SerializeField] private GameObject IceBullet;
    [SerializeField] private GameObject FireBullet;
    private float force = -100f;
    private bool hit = false;
    public GameObject playerposition;
    public float range = 100f;
    //[SerializeField] public Rigidbody rbIceBullet;
    //[SerializeField] public Rigidbody rbFireBullet;
    private bool IceProjectilePowerUp = false;
    private bool FireProjectilePowerUp = false;
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
        if(other.CompareTag("IceBall"))
        {
            IceProjectilePowerUp = true;
            FireProjectilePowerUp = false;
            Destroy(other.gameObject);
        }
        if(other.CompareTag("FireBall"))
        {
            FireProjectilePowerUp = true;
            IceProjectilePowerUp = false;
            Destroy(other.gameObject);
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

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void FixedUpdate()
    {
      
    }

    void Shoot()
    {
        //RaycastHit hit;
        //GameObject newBullet = Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 10f), Quaternion.identity);
        //Rigidbody rbNewBullet = newBullet.GetComponent<Rigidbody>();
        //...Dans la Bullet il faut un sript et dans le Update() : rBody.AddForce(transform.forward * 1f);
        //utiliser un partile system pour une traine de fumer en arri�re


        //rbNewBullet.AddForce(transform.forward * 1f);
        if(IceProjectilePowerUp)
        {
            GameObject newBullet = Instantiate(IceBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 2f), Quaternion.identity);
            Rigidbody rbNewBullet = newBullet.GetComponent<Rigidbody>();
            IceProjectilePowerUp = false;
        }
        else if(FireProjectilePowerUp)
        {
            GameObject newBullet = Instantiate(FireBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 2f), Quaternion.identity);
            Rigidbody rbNewBullet = newBullet.GetComponent<Rigidbody>();
            FireProjectilePowerUp = false;
        }
       

        /*if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {

            
            Debug.Log(hit.transform.name);
            enemy Enemy =  hit.transform.GetComponent<enemy>();

            if(Enemy != null)
            {
                Enemy.TakeHit();
            }

        }*/
    }
}

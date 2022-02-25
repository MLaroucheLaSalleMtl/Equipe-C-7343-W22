using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] public int Live = 3;
    [SerializeField] public Rigidbody rb;
    [SerializeField] private GameObject Bullet;
    private float force = -100f;
    private bool hit = false;
    public GameObject playerposition;
    public float range = 100f;
    [SerializeField] public Rigidbody rbBullet;
    private bool ProjectilePowerup = false;
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
        if(other.CompareTag("Projectile"))
        {
            ProjectilePowerup = true;
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

        if (Input.GetButtonDown("Fire1") && ProjectilePowerup == true)
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
        //utiliser un partile system pour une traine de fumer en arrière


        //rbNewBullet.AddForce(transform.forward * 1f);
        GameObject newBullet = Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 2f), Quaternion.identity);
        Rigidbody rbNewBullet = newBullet.GetComponent<Rigidbody>();
        ProjectilePowerup = false;

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;


    

    void Start()
    {
    }

    void Update()
    {
        
        if(GameObject.FindWithTag("Player").transform.position.z -6 > GameObject.FindWithTag("Track").transform.position.z)
        {
            Destroy(GameObject.FindWithTag("Track"));
        }
        if (GameObject.FindWithTag("Player").transform.position.z - 6 > GameObject.FindWithTag("Trap").transform.position.z)
        {
            Destroy(GameObject.FindWithTag("Trap"));
        }
    }


}

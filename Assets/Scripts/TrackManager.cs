using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackManager : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
    }

    void Update()
    {
        //Destroy objects after crossing them
        if(GameObject.FindWithTag("Player").transform.position.z -12 > GameObject.FindWithTag("Track").transform.position.z)
        {
            Destroy(GameObject.FindWithTag("Track"));
        }
        if (GameObject.FindWithTag("Player").transform.position.z - 12 > GameObject.FindWithTag("Trap").transform.position.z)
        {
            Destroy(GameObject.FindWithTag("Trap"));
        }
        if (GameObject.FindWithTag("Player").transform.position.z - 12 > GameObject.FindWithTag("Live").transform.position.z)
        {
            Destroy(GameObject.FindWithTag("Live"));
        }

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
        Invoke("Destroy", 1.0f);
    }

    private void Destroy()
    {
        Destroy(this.gameObject);
    }

    private void FixedUpdate()
    {
        
        transform.position = new Vector3(0, 0, transform.position.z*(1-speed));
    }
}

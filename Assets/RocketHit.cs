using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("IceBall") || other.CompareTag("FireBall"))
        {
            Destroy(gameObject);
        }
    }
}

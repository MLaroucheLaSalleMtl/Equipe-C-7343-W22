using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticleSystemRocket : MonoBehaviour
{
  [SerializeField]  ParticleSystem Explosion;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle") || other.CompareTag("Trap"))
        {
            ExplosionParticle();
        }
    }

    void ExplosionParticle()
    {
        Explosion.Play();
    }
}

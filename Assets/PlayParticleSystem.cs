using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticleSystem : MonoBehaviour
{
   [SerializeField]  ParticleSystem Blood;
    [SerializeField] ParticleSystem Fire;
    [SerializeField] ParticleSystem Heart;
    private bool isOnFire = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            Blood.Play();
        }
        if(other.CompareTag("FireTrap"))
        {
            StartCoroutine(PlayFireParticle());
            
        }
        if(other.CompareTag("Live"))
        {
           
            if(isOnFire)
            {
                StopFireParticle();
            }
            HeartParticleSystem();

        }
    }
    void PlayBloodparticle()
    {
        Blood.Play();
    }

    void StopFireParticle()
    {
        Fire.Stop();
    }

   IEnumerator  PlayFireParticle()
	{
        Fire.Play();
        isOnFire = true;
        yield return new WaitForSeconds(3);

        Fire.Stop();
        isOnFire = false;

       
	}
    void HeartParticleSystem()
    {
        Heart.Play();
    }
}

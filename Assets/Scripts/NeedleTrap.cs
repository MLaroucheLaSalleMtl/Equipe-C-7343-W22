using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleTrap : MonoBehaviour
{
 

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit");
        if(other.CompareTag("Player"))
        {
            Trappedplayer(other);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Trappedplayer(Collider Character)
    {
      PlayerBehavior player = Character.GetComponent<PlayerBehavior>();

        player.Live--;
       
    }
}

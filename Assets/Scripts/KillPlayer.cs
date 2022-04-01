using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    [SerializeField]   private GameObject Explosion;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }

        if (other.CompareTag("FireBall") || other.CompareTag("IceBall"))
        {
            Instantiate(Explosion, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            Destroy(gameObject.transform.parent.gameObject);

        }

    }
}

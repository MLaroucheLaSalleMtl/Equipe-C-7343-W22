using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source https://www.youtube.com/watch?v=Q4rtR8iNFbY
//programmer 100% Luca
public class gameflow : MonoBehaviour
{
    public Transform trackObj;
    public GameObject[] randomtracks;
    public GameObject[] randomitem;
    private Vector3 nextTrackSpawn;
    private Vector3 nextItemSpawn;
    int[] positions = { -3, 0, 3 };
    void Start()
    {
        nextTrackSpawn.z = 24f;
        StartCoroutine(spawnTrack());
    }

    // Update is called once per frame
    void Update()
    {

        //int n = Random.Range(0, randomtracks.Length);
        //Instantiate(randomtracks[n], nextTrackSpawn, trackObj.rotation);
        //nextTrackSpawn.z += 6f;
    }

    IEnumerator spawnTrack()
    {
        yield return new WaitForSeconds(0.05f);
        int n = Random.Range(0, randomtracks.Length);
        int m = Random.Range(0, randomitem.Length);
        nextItemSpawn = nextTrackSpawn;
        nextItemSpawn.x = positions[Random.Range(0, 3)];
        Instantiate(randomtracks[n], nextTrackSpawn, trackObj.rotation);
        Instantiate(randomitem[m], nextItemSpawn, trackObj.rotation);
        nextTrackSpawn.z += 6f;
        StartCoroutine(spawnTrack());
    }
}

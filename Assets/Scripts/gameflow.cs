using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source https://www.youtube.com/watch?v=Q4rtR8iNFbY
public class gameflow : MonoBehaviour
{
    public Transform trackObj;
    private Vector3 nextTrackSpawn;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(trackObj, nextTrackSpawn, trackObj.rotation);
        nextTrackSpawn.z += 6f;
    }

    //IEnumerable spawnTrack()
    //{
    //    yield return new WaitForSeconds(1);
    //    Instantiate(trackObj, nextTrackSpawn, trackObj.rotation);
    //    nextTrackSpawn.z += 6f;
    //    StartCoroutine(spawnTrack());
    //}
}

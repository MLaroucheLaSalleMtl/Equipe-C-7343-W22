using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 1;

    public void TakeHit()
    {
        speed /= 2;
    }
}

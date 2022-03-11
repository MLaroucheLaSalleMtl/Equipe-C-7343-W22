using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedDisplay : MonoBehaviour
{
    public TMP_Text textSpeed;
    public float speed;
    public PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        speed = player.forwardSpeed*10f;
        textSpeed.text = speed.ToString() + " Km/H";
    }

    // Update is called once per frame
    void Update()
    {
        speed = player.forwardSpeed * 10f;
        textSpeed.text = speed.ToString() + " Km/H";
    }
}

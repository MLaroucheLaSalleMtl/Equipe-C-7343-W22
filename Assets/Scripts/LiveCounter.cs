using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LiveCounter : MonoBehaviour
{
    public Image[] lives;
    [SerializeField] public int Live;
    public int maxLive = 3;
   
    private int livesremaining;
    // Start is called before the first frame update
    void Start()
    {

        Live = maxLive;  
       // livesremaining = Live;
    }

    // Update is called once per frame
    void Update()
    {
        //livesremaining = Live;
        //lives[livesremaining+1].enabled = false;
        if (Live == 3)
        {
            lives[2].enabled = true;
            lives[1].enabled = true;
            lives[0].enabled = true;
        }
        if (Live == 2)
        {
            lives[2].enabled = false;
            lives[1].enabled = true;
            lives[0].enabled = true;
        }
        if (Live == 1)
        {
            lives[2].enabled = false;
            lives[1].enabled = false;
            lives[0].enabled = true;
        }
        if (Live <= 0)
        {
            lives[0].enabled = false;
            SceneManager.LoadScene("Game Over");
        }
    }
}

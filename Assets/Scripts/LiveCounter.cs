using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Nabil 33% Alexy 33% Luca 33%
public class LiveCounter : MonoBehaviour
{
    public Image[] lives;
    [SerializeField] public int Live;
    public int maxLive = 3;
   
    // Start is called before the first frame update
    void Start()
    {

        Live = maxLive;  
    }

    // Update is called once per frame
    void Update()
    {

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
            lives[1].enabled = false;
            SceneManager.LoadScene("Game Over");
        }
    }
}

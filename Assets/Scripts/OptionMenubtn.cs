using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenubtn : MonoBehaviour
{
    GameObject optionsMenu;
    // Start is called before the first frame update
    void Start()
    {
        optionsMenu = GameObject.Find("OptionsMenu");

        optionsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

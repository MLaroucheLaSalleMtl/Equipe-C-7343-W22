using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenubtn : MonoBehaviour
{
  
    private void Start()
    {
    
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Endless Track Test");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


   
}

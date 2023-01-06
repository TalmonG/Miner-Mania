using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void MainMenu()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(0);
    }

    public void MainGame()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(1);
    }

    
}

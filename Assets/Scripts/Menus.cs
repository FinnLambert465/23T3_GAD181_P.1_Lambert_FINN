using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene(3);
    }

    public void Play()
    {
        SceneManager.LoadScene(5);
    }


    public void Quit()
    {
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene(6);
    }

    public void Menu()
    {
        SceneManager.LoadScene(1);
    }
}

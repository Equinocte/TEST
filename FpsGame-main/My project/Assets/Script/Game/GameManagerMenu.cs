using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerMenu : MonoBehaviour
{
   

    public void Play()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ActiveCanvas(GameObject _Name)
    {
        _Name.SetActive(true);
    }

    public void DesactiveCanvas(GameObject _Name)
    {
        _Name.SetActive(false);
    }
}

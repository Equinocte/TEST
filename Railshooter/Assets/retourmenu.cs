using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class retourmenu : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            Debug.Log("PDQQDGsG");
            SceneManager.LoadScene("menu");
        }

    }

}

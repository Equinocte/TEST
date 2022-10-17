using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public int Health;
    public string Name;
    public int EnnemyHealth;
    public GameObject enemyObject;
    // Start is called before the first frame update

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Health = Health + 1;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            EnnemyHealth = EnnemyHealth - 1;

            if (EnnemyHealth == 0)
            {
                Debug.Log("Ennemy's dead.");
                Destroy(enemyObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaBall : MonoBehaviour
{

    public GameObject enemy;

    public float delay = 3f;
    public float damage = 20f;

    float countdown;


    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == enemy)
        {
            enemy.GetComponent<PlayerManager>().Hit(damage);

            Destroy(gameObject);
        }
    }
}

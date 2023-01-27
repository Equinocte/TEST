using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeManager : MonoBehaviour
{

    public float delay = 1f;
    public float radius = 6f;
    public float force = 700f;

    public float damage = 100;

    public GameObject explosionEffetcs;
    public GameObject enemy;

    float countdown;
    bool hasExplosed = false;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
            
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0f && !hasExplosed)
        {
            SoundManager.PlaySound("explosion");
            Explode();
            hasExplosed = true;
        }
    }

    void Explode()
    {
        Instantiate(explosionEffetcs, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if(rb !=null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }

        Destroy(gameObject);
    }

    
}

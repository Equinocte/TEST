using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryWeaponManager : MonoBehaviour
{

    public GameObject playerCam;

    public float range = 100;
    public float damage = 20;

    public GameObject PlasmaBall;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("Fire");
            Plasma();
        }
    }

    void Plasma()
    {
        SoundManager.PlaySound("secondWeapon");

        Vector3 mousePos = Input.mousePosition;
        GameObject PlasmaBal = Instantiate(PlasmaBall, transform.position, transform.rotation);
        Rigidbody rb = PlasmaBal.GetComponent<Rigidbody>();
        rb.AddForce((mousePos - transform.position) / 10, ForceMode.VelocityChange);
    }
}

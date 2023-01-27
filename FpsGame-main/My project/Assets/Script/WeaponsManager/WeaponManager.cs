using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public GameObject playerCam;
    //public GameObject flash;
    public ParticleSystem muzzleFlash;
    public ParticleSystem bloodEffect;


    public float range = 100;
    public float damage = 35;

    public float timeRemaining = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("Fire");
            Shoot();
            muzzleFlash.Play();

            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;  
            }
            else
            {
                //flash.SetActive(false);
            }
        }
    }

    void Shoot()
    {

        //GameObject flashh = Instantiate(flash, transform.position, transform.rotation);
        SoundManager.PlaySound("firstWeapon");

        RaycastHit hit;
        if(Physics.Raycast(playerCam.transform.position, transform.forward, out hit, range ))
        {
            //Debug.Log("Hit");

            EnemyManager enemyManager = hit.transform.GetComponent<EnemyManager>();
            if(enemyManager != null)
            {
                enemyManager.Hit(damage);
                bloodEffect.Play();
            }
        }

        //flash.SetActive(true);
    }
}

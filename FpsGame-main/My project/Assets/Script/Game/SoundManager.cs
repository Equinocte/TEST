using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip firstWeapon, secondWeapon, explosion;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        firstWeapon = Resources.Load<AudioClip>("firstWeapon");
        secondWeapon = Resources.Load<AudioClip>("secondWeapon");
        explosion = Resources.Load<AudioClip>("explosion");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "firstWeapon":
                audioSrc.PlayOneShot(firstWeapon);
                break;
            case "secondWeapon":
                audioSrc.PlayOneShot(secondWeapon);
                break;
            case "explosion":
                audioSrc.PlayOneShot(explosion);
                break;
        }
        
    }
}

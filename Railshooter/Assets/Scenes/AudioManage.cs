using UnityEngine.Audio;
using UnityEngine;

public class AudioManage : MonoBehaviour
{
    public Sounds[] sound;
    void Awake()
    {
        foreach (Sounds s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            
        }
    }

    // Update is called once per frame

    
}

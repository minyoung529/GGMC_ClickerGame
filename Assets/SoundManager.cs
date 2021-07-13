using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region ΩÃ±€≈Ê
    public static SoundManager instance = null;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);
    }
    #endregion

    AudioSource audioSource;
    [SerializeField]
    AudioClip aLittleGhost, spring, summerStorm, nightyNight;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(string music)
    {
        switch(music)
        {
            case "A Little Ghost":
                audioSource.clip = aLittleGhost;
                break;

            case "∫Ω":
                audioSource.clip = spring;
                break;

            case "SUMMER STORM!":
                audioSource.clip = summerStorm;
                break;

            case "Nighty Night":
                audioSource.clip = nightyNight;
                break;
        }

        audioSource.PlayOneShot(audioSource.clip);
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
}

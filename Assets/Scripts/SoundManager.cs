using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region ½Ì±ÛÅæ
    public static SoundManager instance = null;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);
    }
    #endregion

    private AudioSource audioSource;
    [SerializeField]
    private AudioSource effect;
    [SerializeField]
    AudioClip aLittleGhost, spring, summerStorm, nightyNight;
    [SerializeField]
    AudioClip adventure, peacefulVil, bellTower, error, lawn, exploration, happyMemories;
    [SerializeField]
    AudioClip nightWalk, recess, unknown, whirlpool;

    [SerializeField]
    AudioClip mainButton, blop, cash, errorSound, convert;
    private string playerMusic;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playerMusic = PlayerPrefs.GetString("pmusic", "A Little Ghost");
        PlayMusic(playerMusic);
    }

    public void PlayMusic(string music)
    {
        audioSource.Stop();

        switch (music)
        {
            case "A Little Ghost":
                audioSource.clip = aLittleGhost;
                break;

            case "º½":
                audioSource.clip = spring;
                break;

            case "SUMMER STORM!":
                audioSource.clip = summerStorm;
                break;

            case "Nighty Night":
                audioSource.clip = nightyNight;
                break;

            case "¸ðÇè":
                audioSource.clip = adventure;
                break;

            case "ÆòÈ­·Î¿î ¸¶À»":
                audioSource.clip = peacefulVil;
                break;

            case "Bell tower":
                audioSource.clip = bellTower;
                break;

            case "Error":
                audioSource.clip = error;
                break;

            case "Exploration":
                audioSource.clip = exploration;
                break;

            case "Happy memories":
                audioSource.clip = happyMemories;
                break;

            case "Lawn":
                audioSource.clip = lawn;
                break;

            case "Night walk":
                audioSource.clip = nightWalk;
                break;

            case "Recess":
                audioSource.clip = recess;
                break;

            case "Unknown":
                audioSource.clip = unknown;
                break;

            case "Whirlpool":
                audioSource.clip = whirlpool;
                break;
        }

        audioSource.PlayOneShot(audioSource.clip);
    }

    public void StopMusic()
    {
        audioSource.Stop();

        playerMusic = PlayerPrefs.GetString("pmusic", "A Little Ghost");
        PlayMusic(playerMusic);
    }

    public void MainButtonSound()
    {
        effect.PlayOneShot(mainButton);
    }

    public void BlopSound()
    {
        effect.PlayOneShot(blop);
    }

    public void CashSound()
    {
        effect.PlayOneShot(cash);
    }

    public void ErrorSound()
    {
        effect.PlayOneShot(errorSound);
    }

    public void ConvertSound()
    {
        effect.PlayOneShot(convert);
    }
}

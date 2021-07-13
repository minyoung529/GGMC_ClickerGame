using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPlayerMusic : MonoBehaviour
{
    [SerializeField]
    Sprite alg, spring, nighty, summer;

    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        switch (PlayerPrefs.GetString("pmusic", "A Little Ghost"))
        {
            case "A Little Ghost":
                image.sprite = alg;
                break;

            case "º½":
                image.sprite = spring;
                break;

            case "Nighty Night":
                image.sprite = nighty;
                break;

            case "SUMMER STORM!":
                image.sprite = summer;
                break;
        }
    }
}

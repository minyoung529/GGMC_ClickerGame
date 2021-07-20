using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPlayerMusic : MonoBehaviour
{
    [SerializeField]
    Sprite alg, spring, nighty, summer;
    [SerializeField]
    Sprite adv, pv, bell, error, explo, hm, lawn, nw, rece, unk, whirl;

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

            case "봄":
                image.sprite = spring;
                break;

            case "Nighty Night":
                image.sprite = nighty;
                break;

            case "SUMMER STORM!":
                image.sprite = summer;
                break;

            case "모험":
                image.sprite = adv;
                break;

            case "평화로운 마을":
                image.sprite = pv;
                break;

            case "Bell tower":
                image.sprite = bell;
                break;

            case "Error":
                image.sprite = error;
                break;

            case "Exploration":
                image.sprite = explo;
                break;

            case "Happy memories":
                image.sprite = hm;
                break;

            case "Lawn":
                image.sprite = lawn;
                break;

            case "Night walk":
                image.sprite = nw;
                break;

            case "Recess":
                image.sprite = rece;
                break;

            case "Unknown":
                image.sprite = unk;
                break;

            case "Whirlpool":
                image.sprite = whirl;
                break;
        }
    }
}

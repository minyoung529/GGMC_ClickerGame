using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPlayerInst : MonoBehaviour
{
    [SerializeField]
    private Sprite cas, tam, ggang, gui, egui, vi, cel, epia, gaya, syn, drum, harp, horn, clap, flute, easyone, young, lady;

    private Image image;
    private void Awake()
    {
        image = GetComponent<Image>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        switch (PlayerPrefs.GetString("pi", "캐스터네츠"))
        {
            case "캐스터네츠":
                image.sprite = cas;
                break;

            case "탬버린":
                image.sprite = tam;
                break;

            case "기타":
                image.sprite = gui;
                break;

            case "일렉 기타":
                image.sprite = egui;
                break;

            case "디지털 피아노":
                image.sprite = epia;
                break;

            case "신디사이저":
                image.sprite = syn;
                break;

            case "드럼":
                image.sprite = drum;
                break;
        }
    }
}

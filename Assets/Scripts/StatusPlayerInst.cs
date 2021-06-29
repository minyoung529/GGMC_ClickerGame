using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPlayerInst : MonoBehaviour
{
    [SerializeField]
    Sprite cas, tam, gui, egui, epia, syn, drum;

    Image image;

    private void Start()
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

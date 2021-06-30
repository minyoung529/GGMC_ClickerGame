using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerInst : MonoBehaviour
{
    [SerializeField]
    Sprite cas, tam, gui, egui, epia, syn, drum;

    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer= GetComponent<SpriteRenderer>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        switch (PlayerPrefs.GetString("pi", "캐스터네츠"))
        {
            case "캐스터네츠":
                spriteRenderer.sprite = cas;
                break;

            case "탬버린":
                spriteRenderer.sprite = tam;
                break;

            case "기타":
                spriteRenderer.sprite = gui;
                break;

            case "일렉 기타":
                spriteRenderer.sprite = egui;
                break;

            case "디지털 피아노":
                spriteRenderer.sprite = epia;
                break;

            case "신디사이저":
                spriteRenderer.sprite = syn;
                break;

            case "드럼":
                spriteRenderer.sprite = drum;
                break;
        }
    }
}

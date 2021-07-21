using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerInst : MonoBehaviour
{
    [SerializeField]
    private Sprite cas, tam, ggang, gui, egui, vi, cel, epia, gaya, syn, drum, harp, horn, clap, flute, easyone, young, lady;


    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        string instName = PlayerPrefs.GetString("pi", "꽹과리");
        instName = "플루트";
        switch (instName)
        {
            case "캐스터네츠":
                spriteRenderer.sprite = cas;
                transform.localScale = new Vector2(0.6f, 0.6f);
                transform.localPosition = new Vector2(1.2f, -0.3f);
                break;

            case "탬버린":
                spriteRenderer.sprite = tam;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(0.6f, 0.6f);
                break;

            case "꽹과리":
                spriteRenderer.sprite = ggang;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(0.6f, 0.6f);
                break;

            case "기타":
                spriteRenderer.sprite = gui;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "일렉 기타":
                spriteRenderer.sprite = egui;
                transform.localPosition = new Vector2(0.7f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "바이올린":
                spriteRenderer.sprite = vi;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(0.8f, 0.8f);
                break;

            case "첼로":
                spriteRenderer.sprite = cel;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "디지털 피아노":
                spriteRenderer.sprite = epia;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(1.2f, 1.2f);
                break;

            case "가야금":
                spriteRenderer.sprite = gaya;
                transform.localPosition = new Vector2(0.7f, -0.4f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "신디사이저":
                spriteRenderer.sprite = syn;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(0.8f, 0.8f);
                break;

            case "드럼":
                spriteRenderer.sprite = drum;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(1.3f, 1.3f);
                break;

            case "하프":
                spriteRenderer.sprite = harp;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "호른":
                spriteRenderer.sprite = horn;
                transform.localPosition = new Vector2(0.8f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "박수":
                spriteRenderer.sprite = clap;
                transform.localPosition = new Vector2(0.9f, -0.2f);
                transform.localScale = new Vector2(0.6f, 0.6f);
                break;

            case "플루트":
                spriteRenderer.sprite = flute;
                transform.localPosition = new Vector2(-0.9f, 0.5f);
                transform.localScale = new Vector2(0.9f, 0.9f);
                break;

            case "EasyOne":
                spriteRenderer.sprite = cel;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "Young's HanD":
                spriteRenderer.sprite = epia;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(1.2f, 1.2f);
                break;

            case "레이디 테넌트":
                spriteRenderer.sprite = gaya;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(1.2f, 1.2f);
                break;
        }
    }
}

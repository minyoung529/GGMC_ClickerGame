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
        gameObject.transform.localPosition = Vector2.zero;
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        switch (PlayerPrefs.GetString("pi", "캐스터네츠"))
        {
            case "캐스터네츠":
                spriteRenderer.sprite = cas;
                transform.localScale = new Vector2(0.6f, 0.6f);
                transform.localPosition = new Vector3(1.2f, -0.3f, 1f);
                break;

            case "탬버린":
                spriteRenderer.sprite = tam;
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
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "디지털 피아노":
                spriteRenderer.sprite = epia;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(1.2f, 1.2f);
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

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
        switch (PlayerPrefs.GetString("pi", "ĳ���ͳ���"))
        {
            case "ĳ���ͳ���":
                spriteRenderer.sprite = cas;
                transform.localScale = new Vector2(0.6f, 0.6f);
                transform.localPosition = new Vector3(1.2f, -0.3f, 1f);
                break;

            case "�ƹ���":
                spriteRenderer.sprite = tam;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(0.6f, 0.6f);
                break;

            case "��Ÿ":
                spriteRenderer.sprite = gui;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "�Ϸ� ��Ÿ":
                spriteRenderer.sprite = egui;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "������ �ǾƳ�":
                spriteRenderer.sprite = epia;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(1.2f, 1.2f);
                break;

            case "�ŵ������":
                spriteRenderer.sprite = syn;
                break;

            case "�巳":
                spriteRenderer.sprite = drum;
                break;
        }
    }
}

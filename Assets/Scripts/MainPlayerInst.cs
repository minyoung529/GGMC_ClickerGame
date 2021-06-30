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
        switch (PlayerPrefs.GetString("pi", "ĳ���ͳ���"))
        {
            case "ĳ���ͳ���":
                spriteRenderer.sprite = cas;
                break;

            case "�ƹ���":
                spriteRenderer.sprite = tam;
                break;

            case "��Ÿ":
                spriteRenderer.sprite = gui;
                break;

            case "�Ϸ� ��Ÿ":
                spriteRenderer.sprite = egui;
                break;

            case "������ �ǾƳ�":
                spriteRenderer.sprite = epia;
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

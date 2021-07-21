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
        string instName = PlayerPrefs.GetString("pi", "ĳ���ͳ���");

        switch (instName)
        {
            case "ĳ���ͳ���":
                spriteRenderer.sprite = cas;
                transform.localScale = new Vector2(0.6f, 0.6f);
                transform.localPosition = new Vector2(1.2f, -0.3f);
                break;

            case "�ƹ���":
            case "������":
                spriteRenderer.sprite = (instName == "�ƹ���") ? tam :  ggang;
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

            case "���̿ø�":
                spriteRenderer.sprite = vi;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "ÿ��":
                spriteRenderer.sprite = cel;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "������ �ǾƳ�":
                spriteRenderer.sprite = epia;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(1.2f, 1.2f);
                break;

            case "���߱�":
                spriteRenderer.sprite = gaya;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(1.2f, 1.2f);
                break;

            case "�ŵ������":
                spriteRenderer.sprite = syn;
                break;

            case "�巳":
                spriteRenderer.sprite = drum;
                break;

            case "����":
                spriteRenderer.sprite = vi;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "ȣ��":
                spriteRenderer.sprite = cel;
                transform.localPosition = new Vector2(1f, -0.3f);
                transform.localScale = new Vector2(1f, 1f);
                break;

            case "�ڼ�":
                spriteRenderer.sprite = epia;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(1.2f, 1.2f);
                break;

            case "�÷�Ʈ":
                spriteRenderer.sprite = gaya;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(1.2f, 1.2f);
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

            case "���̵� �׳�Ʈ":
                spriteRenderer.sprite = gaya;
                transform.localPosition = new Vector2(0f, -0.8f);
                transform.localScale = new Vector2(1.2f, 1.2f);
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerMIC : MonoBehaviour
{
    [SerializeField]
    Sprite kara, dyn, gg157, con, year, mi;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        switch (PlayerPrefs.GetString("pm", "�뷡�� ����ũ"))
        {
            case "�뷡�� ����ũ":
                spriteRenderer.sprite = kara;
                break;

            case "���̳��� ����ũ":
                spriteRenderer.sprite = dyn;
                break;

            case "GG157":
                spriteRenderer.sprite = gg157;
                break;

            case "�ܵ��� ����ũ":
                spriteRenderer.sprite = con;
                break;

            case "���̾� ����ũ":
                spriteRenderer.sprite = year;
                break;

            case "���̽�Ʈ��":
                spriteRenderer.sprite = mi;
                break;
        }
    }
}

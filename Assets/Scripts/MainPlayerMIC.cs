using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerMIC : MonoBehaviour
{
    [SerializeField]
    Sprite gar, pororo, kara, used, well, gg157, broad, idol, shiba, studio, angel, voice;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        switch (PlayerPrefs.GetString("pm", "�������뿡�� �ֿ� ����ũ"))
        {
            case "�������뿡�� �ֿ� ����ũ":
                spriteRenderer.sprite = gar;
                transform.localPosition = new Vector2(-0.6f, -0.7f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;

            case "�Ƿη� ����ũ":
                spriteRenderer.sprite = pororo;
                transform.localPosition = new Vector2(0.1f, -0.2f);
                transform.localScale = new Vector2(0.6f, 0.6f);
                transform.localScale = new Vector2(0.6f, 0.6f);
                break;

            case "�뷡�濡�� ������ ����ũ":
                spriteRenderer.sprite = kara;
                transform.localPosition = new Vector2(0.1f, -0.2f);
                transform.localScale = new Vector2(0.6f, 0.6f);
                break;

            case "�ſ� �߰� ����ũ":
                spriteRenderer.sprite = used;
                transform.localPosition = new Vector2(-0.7f, -0.7f);
                transform.localScale = new Vector2(0.8f, 0.8f);
                break;

            case "�� ���� ���̴� ����ũ":
                spriteRenderer.sprite = well;
                transform.localPosition = new Vector2(0.2f, -1f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;

            case "GG157":
                spriteRenderer.sprite = gg157;
                transform.localPosition = Vector2.zero;
                transform.localScale = new Vector2(0.6f, 0.6f);
                break;

            case "��ۿ� ����ũ":
                spriteRenderer.sprite = broad;
                transform.localPosition = new Vector2(-1f, -0.5f);
                transform.localScale = new Vector2(0.85f, 0.85f);
                break;

            case "���̵��� �� ���� ����ũ":
                spriteRenderer.sprite = idol;
                transform.localPosition = new Vector2(-0.9f, 0.62f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;

            case "Shiba's VoicE":
                spriteRenderer.sprite = shiba;
                transform.localPosition = new Vector2(0f, -0.3f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;

            case "��Ʃ��� ����ũ":
                spriteRenderer.sprite = studio;
                transform.localPosition = new Vector2(-0.67f, -0.4f);
                transform.localScale = new Vector2(0.9f, 0.9f);
                break;

            case "The Angel's Ring":
                spriteRenderer.sprite = angel;
                transform.localPosition = new Vector2(0f, -0.3f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;

            case "��Ҹ�":
                spriteRenderer.sprite = voice;
                transform.localPosition = new Vector2(1.4f, 0.7f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;
        }
    }
}
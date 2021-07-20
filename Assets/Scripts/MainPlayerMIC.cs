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
                break;

            case "�Ƿη� ����ũ":
                spriteRenderer.sprite = pororo;
                break;

            case "�뷡�濡�� ������ ����ũ":
                spriteRenderer.sprite = kara;
                break;

            case "�ſ� �߰� ����ũ":
                spriteRenderer.sprite = used;
                break;

            case "�� ���� ���̴� ����ũ":
                spriteRenderer.sprite = well;
                break;

            case "GG157":
                spriteRenderer.sprite = gg157;
                break;

            case "��ۿ� ����ũ":
                spriteRenderer.sprite = broad;
                break;

            case "���̵��� �� ���� ����ũ":
                spriteRenderer.sprite = idol;
                break;

            case "Shiba's VoicE":
                spriteRenderer.sprite = shiba;
                break;

            case "��Ʃ��� ����ũ":
                spriteRenderer.sprite = studio;
                break;

            case "The Angel's Ring":
                spriteRenderer.sprite = angel;
                break;

            case "��Ҹ�":
                spriteRenderer.sprite = voice;
                break;
        }
    }
}
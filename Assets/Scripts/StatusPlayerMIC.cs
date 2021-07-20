using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPlayerMIC : MonoBehaviour
{
    [SerializeField]
    Sprite gar, pororo, kara, used, well, gg157, broad, idol, shiba, studio, angel, voice;

    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        Debug.Log(PlayerPrefs.GetString("pm", "�������뿡�� �ֿ� ����ũ"));
        switch (PlayerPrefs.GetString("pm", "�������뿡�� �ֿ� ����ũ"))
        {
            case "�������뿡�� �ֿ� ����ũ":
                image.sprite = gar;
                break;

            case "�Ƿη� ����ũ":
                image.sprite = pororo;
                break;

            case "�뷡�濡�� ������ ����ũ":
                image.sprite = kara;
                break;

            case "�ſ� �߰� ����ũ":
                image.sprite = used;
                break;

            case "�� ���� ���̴� ����ũ":
                image.sprite = well;
                break;

            case "GG157":
                image.sprite = gg157;
                break;

            case "��ۿ� ����ũ":
                image.sprite = broad;
                break;

            case "���̵��� �� ���� ����ũ":
                image.sprite = idol;
                break;

            case "Shiba's VoicE":
                image.sprite = shiba;
                break;

            case "��Ʃ��� ����ũ":
                image.sprite = studio;
                break;

            case "The Angel's Ring":
                image.sprite = angel;
                break;

            case "��Ҹ�":
                image.sprite = voice;
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPlayerMIC : MonoBehaviour
{
    [SerializeField]
    Sprite kara, dyn, gg157, con, year, mi;

    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        switch (PlayerPrefs.GetString("pm", "�뷡�� ����ũ"))
        {
            case "�뷡�� ����ũ":
                image.sprite = kara;
                break;

            case "���̳��� ����ũ":
                image.sprite = dyn;
                break;

            case "GG157":
                image.sprite = gg157;
                break;

            case "�ܵ��� ����ũ":
                image.sprite = con;
                break;

            case "���̾� ����ũ":
                image.sprite = year;
                break;

            case "���̽�Ʈ��":
                image.sprite = mi;
                break;
        }
    }
}

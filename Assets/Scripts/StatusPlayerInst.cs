using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPlayerInst : MonoBehaviour
{
    [SerializeField]
    Sprite cas, tam, gui, egui, epia, syn, drum;

    Image image;

    private void Start()
    {
        image = GetComponent<Image>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        switch (PlayerPrefs.GetString("pi", "ĳ���ͳ���"))
        {
            case "ĳ���ͳ���":
                image.sprite = cas;
                break;

            case "�ƹ���":
                image.sprite = tam;
                break;

            case "��Ÿ":
                image.sprite = gui;
                break;

            case "�Ϸ� ��Ÿ":
                image.sprite = egui;
                break;

            case "������ �ǾƳ�":
                image.sprite = epia;
                break;

            case "�ŵ������":
                image.sprite = syn;
                break;

            case "�巳":
                image.sprite = drum;
                break;
        }
    }
}

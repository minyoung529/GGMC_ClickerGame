using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPlayerInst : MonoBehaviour
{
    [SerializeField]
    private Sprite cas, tam, ggang, gui, egui, vi, cel, epia, gaya, syn, drum, harp, horn, clap, flute, easyone, young, lady;

    private Image image;
    private void Awake()
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

            case "������":
                image.sprite = ggang;
                break;

            case "��Ÿ":
                image.sprite = gui;
                break;

            case "�Ϸ� ��Ÿ":
                image.sprite = egui;
                break;

            case "���̿ø�":
                image.sprite = vi;
                break;

            case "ÿ��":
                image.sprite = cel;
                break;

            case "������ �ǾƳ�":
                image.sprite = epia;
                break;

            case "���߱�":
                image.sprite = gaya;
                break;

            case "�ŵ������":
                image.sprite = syn;
                break;

            case "�巳":
                image.sprite = drum;
                break;

            case "����":
                image.sprite = harp;
                break;

            case "ȣ��":
                image.sprite = cel;
                break;

            case "�ڼ�":
                image.sprite = epia;
                break;

            case "�÷�Ʈ":
                image.sprite = gaya;
                break;

            case "EasyOne":
                image.sprite = cel;
                break;

            case "Young's HanD":
                image.sprite = epia;
                break;

            case "���̵� �׳�Ʈ":
                image.sprite = gaya;
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status_Inst_Btn : MonoBehaviour
{
    [SerializeField]
    Image btnImage, playerInstImage;
    [SerializeField]
    Sprite instEnabled;
    [SerializeField]
    GameObject choosePopup;
    [SerializeField]
    Text chooseText;
    [SerializeField]
    SpriteRenderer playerInst;

    private string btnName;
    private int money;
    private int popular;
    private int moneyPS;
    private Sprite instSprite;
    private string info;
    public Instrument inst;

    void Start()
    {
        ChangeSprite();
    }

    public void Setup(Instrument instData)
    {
        this.inst = instData;
        this.btnName = instData.instName;
        this.money = instData.money;
        this.popular = instData.popular;
        this.moneyPS = instData.moneyPerSec;
        this.instSprite = instData.instSprite;
        this.info = instData.info;

        ChangeSprite();
    }

    public void ChangeSprite()
    {
        if(btnName == "�ƹ���" && PlayerPrefs.GetString("inst11") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "��Ÿ" && PlayerPrefs.GetString("inst22") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "�Ϸ� ��Ÿ" && PlayerPrefs.GetString("inst33") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "������ �ǾƳ�" && PlayerPrefs.GetString("inst44") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "�ŵ������" && PlayerPrefs.GetString("inst55") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "�巳" && PlayerPrefs.GetString("inst66") == "isSold")
        {
            btnImage.sprite = instSprite;
        }
    }

    public void SelectChoose()
    {
        if (btnImage.sprite == instEnabled) return;
        choosePopup.SetActive(false);

        PlayerPrefs.SetString("pi", btnName);
        PlayerPrefs.SetInt("tm", moneyPS);
        GameManager.Instance.UpdateUI();
    }
}

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
        if(btnName == "�ƹ���" && PlayerPrefs.GetString("inst1") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "������" && PlayerPrefs.GetString("inst2") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "��Ÿ" && PlayerPrefs.GetString("inst3") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "�Ϸ� ��Ÿ" && PlayerPrefs.GetString("inst4") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "���̿ø�" && PlayerPrefs.GetString("inst5") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "ÿ��" && PlayerPrefs.GetString("inst6") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "������ �ǾƳ�" && PlayerPrefs.GetString("inst7") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "���߱�" && PlayerPrefs.GetString("inst8") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "�ŵ������" && PlayerPrefs.GetString("inst9") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "�巳" && PlayerPrefs.GetString("inst10") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "����" && PlayerPrefs.GetString("inst11") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "ȣ��" && PlayerPrefs.GetString("inst12") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "�ڼ�" && PlayerPrefs.GetString("inst13") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "�÷�Ʈ" && PlayerPrefs.GetString("inst14") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "EasyOne" && PlayerPrefs.GetString("inst15") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "Young's HanD" && PlayerPrefs.GetString("inst16") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "���̵� �׳�Ʈ" && PlayerPrefs.GetString("inst17") == "isSold")
        {
            btnImage.sprite = instSprite;
        }
    }

    public void SelectChoose()
    {
        choosePopup.SetActive(false);

        PlayerPrefs.SetString("pi", btnName);
        PlayerPrefs.SetInt("instPS", moneyPS);
        GameManager.Instance.UpdateUI();
    }

    public void OnClickInst()
    {
        if (btnImage.sprite == instEnabled) return;

        choosePopup.SetActive(true);
        Text nameText = choosePopup.transform.GetChild(0).GetComponentInChildren<Text>();
        Text informText = choosePopup.transform.GetChild(1).GetComponentInChildren<Text>();
        Text secText = choosePopup.transform.GetChild(2).GetComponentInChildren<Text>();

        nameText.text = string.Format("{0}", btnName);
        informText.text = string.Format("{0}", info);
        secText.text = string.Format("5Sec - {0}", moneyPS);
    }

    public void OnClickPutInst()
    {
        Text nameText = choosePopup.transform.GetChild(0).GetComponentInChildren<Text>();

        if(nameText.text == btnName)
        {
            SelectChoose();
        }
    }
}

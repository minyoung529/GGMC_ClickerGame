using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status_MIC_Btn : MonoBehaviour
{
    [SerializeField]
    Image btnImage, playerMICImage;
    [SerializeField]
    Sprite micEnabled;
    [SerializeField]
    GameObject choosePopup;
    [SerializeField]
    Text chooseText;

    private string btnName;
    private int money;
    private int popular;
    private int moneyPS;
    private Sprite instSprite;
    private string info;
    public MIC mic;

    public void Setup(MIC mic)
    {
        this.mic = mic;
        this.btnName = mic.micName;
        this.money = mic.money;
        this.popular = mic.popular;
        this.moneyPS = mic.moneyPerSec;
        this.instSprite = mic.micSprite;
        this.info = mic.info;

        ChangeSprite();
    }

    public void ChangeSprite()
    {
        if (btnName == null) return;

        else if (btnName == "�Ƿη� ����ũ" && PlayerPrefs.GetString("mic2") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "�뷡�濡�� ������ ����ũ" && PlayerPrefs.GetString("mic3") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "�ſ� �߰� ����ũ" && PlayerPrefs.GetString("mic4") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "�� ���� ���̴� ����ũ" && PlayerPrefs.GetString("mic5") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "GG157" && PlayerPrefs.GetString("mic6") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "��ۿ� ����ũ" && PlayerPrefs.GetString("mic7") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "���̵��� �� ���� ����ũ" && PlayerPrefs.GetString("mic8") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "Shiba's VoicE" && PlayerPrefs.GetString("mic9") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "��Ʃ��� ����ũ" && PlayerPrefs.GetString("mic10") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "The Angel's Ring" && PlayerPrefs.GetString("mic11") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "��Ҹ�" && PlayerPrefs.GetString("mic12") == "isSold")
        {
            btnImage.sprite = instSprite;
        }
    }

    public void SelectChoose()
    {
        choosePopup.SetActive(false);

        PlayerPrefs.SetString("pm", btnName);
        PlayerPrefs.SetInt("micPS", moneyPS);
        GameManager.Instance.UpdateUI();
    }

    public void OnClickMIC()
    {
        if (btnImage.sprite == micEnabled) return;

        choosePopup.SetActive(true);
        Text nameText = choosePopup.transform.GetChild(0).GetComponentInChildren<Text>();
        Text informText = choosePopup.transform.GetChild(1).GetComponentInChildren<Text>();
        Text secText = choosePopup.transform.GetChild(2).GetComponentInChildren<Text>();

        nameText.text = string.Format("{0}", btnName);
        informText.text = string.Format("{0}", info);
        secText.text = string.Format("5Sec - {0}", moneyPS);
    }

    public void OnClickPutMIC()
    {
        Text nameText = choosePopup.transform.GetChild(0).GetComponentInChildren<Text>();

        if (nameText.text == btnName)
        {
            SelectChoose();
        }
    }
}

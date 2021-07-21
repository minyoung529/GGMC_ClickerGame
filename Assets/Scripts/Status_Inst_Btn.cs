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
        if(btnName == "탬버린" && PlayerPrefs.GetString("inst1") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "깽과리" && PlayerPrefs.GetString("inst2") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "기타" && PlayerPrefs.GetString("inst3") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "일렉 기타" && PlayerPrefs.GetString("inst4") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "바이올린" && PlayerPrefs.GetString("inst5") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "첼로" && PlayerPrefs.GetString("inst6") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "디지털 피아노" && PlayerPrefs.GetString("inst7") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "가야금" && PlayerPrefs.GetString("inst8") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "신디사이저" && PlayerPrefs.GetString("inst9") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "드럼" && PlayerPrefs.GetString("inst10") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "하프" && PlayerPrefs.GetString("inst11") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "호른" && PlayerPrefs.GetString("inst12") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "박수" && PlayerPrefs.GetString("inst13") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "플루트" && PlayerPrefs.GetString("inst14") == "isSold")
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

        else if (btnName == "레이디 테넌트" && PlayerPrefs.GetString("inst17") == "isSold")
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

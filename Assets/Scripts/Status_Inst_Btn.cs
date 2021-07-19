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
        if(btnName == "탬버린" && PlayerPrefs.GetString("inst11") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "기타" && PlayerPrefs.GetString("inst22") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "일렉 기타" && PlayerPrefs.GetString("inst33") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "디지털 피아노" && PlayerPrefs.GetString("inst44") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "신디사이저" && PlayerPrefs.GetString("inst55") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "드럼" && PlayerPrefs.GetString("inst66") == "isSold")
        {
            btnImage.sprite = instSprite;
        }
    }

    public void SelectChoose()
    {
        if (btnImage.sprite == instEnabled) return;
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

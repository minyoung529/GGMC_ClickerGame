using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstButtons : MonoBehaviour
{
    private string btnName;
    private int money;
    private int popular;
    private int moneyPS;
    private Sprite instSprite;
    private string info;

    private bool isBuy = false;

    public Instrument inst;
    private int originPopular;

    [SerializeField]
    GameObject BuyPopup, instContents;
    [SerializeField]
    Text nameText, infoText, detailText, moneyText, popularText;
    [SerializeField]
    Image instImage, buttonImage;
    [SerializeField]
    Sprite isSold, isEnabled;
    [SerializeField]
    GameObject contents;

    private void Start()
    {
        SetUpData();
        originPopular = PlayerPrefs.GetInt("p1", 0);
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
    }

    private void SetUpData()
    {
        switch (btnName)
        {
            case "탬버린":
                PlayerPrefs.GetString("inst1", "isSell");
                break;

            case "깽과리":
                PlayerPrefs.GetString("inst2", "isSell");
                break;

            case "기타":
                PlayerPrefs.GetString("inst3", "isSell");
                break;

            case "일렉 기타":
                PlayerPrefs.GetString("inst4", "isSell");
                break;

            case "바이올린":
                PlayerPrefs.GetString("inst5", "isSell");
                break;

            case "첼로":
                PlayerPrefs.GetString("inst6", "isSell");
                break;

            case "디지털 피아노":
                PlayerPrefs.GetString("inst7", "isSell");
                break;

            case "가야금":
                PlayerPrefs.GetString("inst8", "isSell");
                break;

            case "신디사이저":
                PlayerPrefs.GetString("inst9", "isSell");
                break;

            case "드럼":
                PlayerPrefs.GetString("inst10", "isSell");
                break;

            case "하프":
                PlayerPrefs.GetString("inst11", "isSell");
                break;

            case "호른":
                PlayerPrefs.GetString("inst12", "isSell");
                break;

            case "박수":
                PlayerPrefs.GetString("inst13", "isSell");
                break;

            case "플루트":
                PlayerPrefs.GetString("inst14", "isSell");
                break;

            case "EasyOne":
                PlayerPrefs.GetString("inst15", "isSell");
                break;

            case "Young's HanD":
                PlayerPrefs.GetString("inst16", "isSell");
                break;

            case "레이디 테넌트":
                PlayerPrefs.GetString("inst17", "isSell");
                break;
        }
        CheckData();
    }

    private void ChangeData(string productName)
    {
        switch (productName)
        {
            case "탬버린":
                PlayerPrefs.SetString("inst1", "isSold");
                break;

            case "깽과리":
                PlayerPrefs.SetString("inst2", "isSold");
                break;

            case "기타":
                PlayerPrefs.SetString("inst3", "isSold");
                break;

            case "일렉 기타":
                PlayerPrefs.SetString("inst4", "isSold");
                break;

            case "바이올린":
                PlayerPrefs.SetString("inst5", "isSold");
                break;

            case "첼로":
                PlayerPrefs.SetString("inst6", "isSold");
                break;

            case "디지털 피아노":
                PlayerPrefs.SetString("inst7", "isSold");
                break;

            case "가야금":
                PlayerPrefs.SetString("inst8", "isSold");
                break;

            case "신디사이저":
                PlayerPrefs.SetString("inst9", "isSold");
                break;

            case "드럼":
                PlayerPrefs.SetString("inst10", "isSold");
                break;

            case "하프":
                PlayerPrefs.SetString("inst11", "isSold");
                break;

            case "호른":
                PlayerPrefs.SetString("inst12", "isSold");
                break;

            case "박수":
                PlayerPrefs.SetString("inst13", "isSold");
                break;

            case "플루트":
                PlayerPrefs.SetString("inst14", "isSold");
                break;

            case "EasyOne":
                PlayerPrefs.SetString("inst15", "isSold");
                break;

            case "Young's HanD":
                PlayerPrefs.SetString("inst16", "isSell");
                break;

            case "레이디 테넌트":
                PlayerPrefs.SetString("inst17", "isSold");
                break;
        }

        CheckData();
    }

    public void CheckData()
    {
        if (PlayerPrefs.GetString("inst1") == "isSold" && gameObject.transform == contents.transform.GetChild(0))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst2") == "isSold" && gameObject.transform == contents.transform.GetChild(1))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst3") == "isSold" && gameObject.transform == contents.transform.GetChild(2))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst4") == "isSold" && gameObject.transform == contents.transform.GetChild(3))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst5") == "isSold" && gameObject.transform == contents.transform.GetChild(4))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }
        if (PlayerPrefs.GetString("inst6") == "isSold" && gameObject.transform == contents.transform.GetChild(5))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst7") == "isSold" && gameObject.transform == contents.transform.GetChild(6))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst8") == "isSold" && gameObject.transform == contents.transform.GetChild(7))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst9") == "isSold" && gameObject.transform == contents.transform.GetChild(8))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst10") == "isSold" && gameObject.transform == contents.transform.GetChild(9))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst11") == "isSold" && gameObject.transform == contents.transform.GetChild(10))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }
        if (PlayerPrefs.GetString("inst12") == "isSold" && gameObject.transform == contents.transform.GetChild(11))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst13") == "isSold" && gameObject.transform == contents.transform.GetChild(12))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst14") == "isSold" && gameObject.transform == contents.transform.GetChild(13))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst15") == "isSold" && gameObject.transform == contents.transform.GetChild(14))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst16") == "isSold" && gameObject.transform == contents.transform.GetChild(15))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst17") == "isSold" && gameObject.transform == contents.transform.GetChild(16))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }
    }

    public void OnClickBuy()
    {
        if (isBuy) return;
        if (buttonImage.sprite == isEnabled) return;

        BuyPopup.SetActive(true);

        nameText.text = string.Format("{0}", btnName);
        infoText.text = string.Format("{0}", info);
        detailText.text = string.Format("5초당 획득 돈: {0}원\n인기도 +{1}원", moneyPS, popular);
        moneyText.text = string.Format("{0}", money);
        popularText.text = string.Format("{0}", popular);
        instImage.sprite = instSprite;
    }

    public void ChooseBuy()
    {
        int productMoney;
        string productName;
        int productPopular;

        productMoney = int.Parse(moneyText.text);
        productName = nameText.text;
        productPopular = int.Parse(popularText.text);

        if (GameManager.Instance.playerMoney - productMoney <= 0)
        {
            SoundManager.instance.ErrorSound();
            return;
        }

        BuyPopup.SetActive(false);

        GameManager.Instance.Min(productMoney);
        originPopular += productPopular;
        PlayerPrefs.SetInt("p1", originPopular);

        ChangeData(productName);
        CheckData();
        GameManager.Instance.UpdateUI();
        SoundManager.instance.CashSound();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MICButtons : MonoBehaviour
{
    private string btnName;
    private int money;
    private int popular;
    private int moneyPS;
    private Sprite micSprite;
    private string info;

    private bool isBuy = false;

    public MIC mic;
    private int originPopular;

    [SerializeField]
    GameObject BuyPopup, instContents;
    [SerializeField]
    Text nameText, infoText, detailText, moneyText;
    [SerializeField]
    Image micImage, buttonImage;
    [SerializeField]
    Sprite isSold;
    [SerializeField]
    GameObject contents;

    void Start()
    {
        SetUpData();
        buttonImage.sprite = micSprite;
    }

    public void Setup(MIC mic)
    {
        this.mic = mic;
        this.btnName = mic.micName;
        this.money = mic.money;
        this.popular = mic.popular;
        this.moneyPS = mic.moneyPerSec;
        this.micSprite = mic.micSprite;
        this.info = mic.info;
    }

    private void SetUpData()
    {
        switch (btnName)
        {
            case "탬버린":
                PlayerPrefs.GetString("mic1", "isSell");
                break;

            case "기타":
                PlayerPrefs.GetString("mic2", "isSell");
                break;

            case "일렉 기타":
                PlayerPrefs.GetString("mic3", "isSell");
                break;

            case "디지털 피아노":
                PlayerPrefs.GetString("mic4", "isSell");
                break;

            case "신디사이저":
                PlayerPrefs.GetString("mic5", "isSell");
                break;

            case "드럼":
                PlayerPrefs.GetString("mic6", "isSell");
                break;
        }
        CheckData();
    }

    private void ChangeData(string productName)
    {
        switch (productName)
        {
            case "다이나믹 마이크":
                PlayerPrefs.SetString("mic1", "isSold");
                break;

            case "GG157":
                PlayerPrefs.SetString("mic2", "isSold");
                break;

            case "콘덴서 마이크":
                PlayerPrefs.SetString("mic3", "isSold");
                break;

            case "인이어 마이크":
                PlayerPrefs.SetString("mic4", "isSold");
                break;

            case "마이스트로":
                PlayerPrefs.SetString("mic5", "isSold");
                break;
        }
        CheckData();
    }

    public void CheckData()
    {
        if (PlayerPrefs.GetString("mic1") == "isSold" && gameObject.transform == contents.transform.GetChild(0))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("mic2") == "isSold" && gameObject.transform == contents.transform.GetChild(1))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("mic3") == "isSold" && gameObject.transform == contents.transform.GetChild(2))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("mic4") == "isSold" && gameObject.transform == contents.transform.GetChild(3))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("mic5") == "isSold" && gameObject.transform == contents.transform.GetChild(4))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }
        if (PlayerPrefs.GetString("mic6") == "isSold" && gameObject.transform == contents.transform.GetChild(5))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }
    }

    public void OnClickBuy()
    {
        if (isBuy) return;
        BuyPopup.SetActive(true);

        nameText.text = string.Format("{0}", btnName);
        infoText.text = string.Format("{0}", info);
        detailText.text = string.Format("5초당 획득 돈: {0}원\n인기도 +{1}원", moneyPS, popular);
        moneyText.text = string.Format("{0}", money);
        micImage.sprite = micSprite;
    }

    public void ChooseBuy()
    {
        int productMoney;
        string productName;
        productMoney = int.Parse(moneyText.text);
        productName = nameText.text;

        if (GameManager.Instance.playerMoney - productMoney <= 0) return;

        BuyPopup.SetActive(false);

        GameManager.Instance.Min(productMoney);
        originPopular += popular;
        PlayerPrefs.SetInt("p1", originPopular);

        ChangeData(productName);
        CheckData();
        GameManager.Instance.UpdateUI();
    }
}

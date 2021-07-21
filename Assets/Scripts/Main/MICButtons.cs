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
    GameObject BuyPopup;
    [SerializeField]
    Text nameText, infoText, detailText, moneyText, popularText;
    [SerializeField]
    Image micImage, buttonImage;
    [SerializeField]
    Sprite isSold, isEnabled;
    [SerializeField]
    GameObject contents;

    void Start()
    {
        SetUpData();
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
            case "뽀로로 마이크":
                PlayerPrefs.GetString("mic2", "isSell");
                break;

            case "노래방에서 가져온 마이크":
                PlayerPrefs.GetString("mic3", "isSell");
                break;

            case "매우 중고 마이크":
                PlayerPrefs.GetString("mic4", "isSell");
                break;

            case "좀 좋아 보이는 마이크":
                PlayerPrefs.GetString("mic5", "isSell");
                break;

            case "GG157":
                PlayerPrefs.GetString("mic6", "isSell");
                break;

            case "방송용 마이크":
                PlayerPrefs.GetString("mic7", "isSell");
                break;

            case "아이돌이 쓸 법한 마이크":
                PlayerPrefs.GetString("mic8", "isSell");
                break;

            case "Shiba's VoicE":
                PlayerPrefs.GetString("mic9", "isSell");
                break;

            case "스튜디오 마이크":
                PlayerPrefs.GetString("mic10", "isSell");
                break;

            case "The Angel's Ring":
                PlayerPrefs.GetString("mic11", "isSell");
                break;

            case "목소리":
                PlayerPrefs.GetString("mic12", "isSell");
                break;
        }
        CheckData();
    }

    private void ChangeData(string productName)
    {
        switch (productName)
        {
            case "뽀로로 마이크":
                PlayerPrefs.SetString("mic2", "isSold");
                break;

            case "노래방에서 가져온 마이크":
                PlayerPrefs.SetString("mic3", "isSold");
                break;

            case "매우 중고 마이크":
                PlayerPrefs.SetString("mic4", "isSold");
                break;

            case "좀 좋아 보이는 마이크":
                PlayerPrefs.SetString("mic5", "isSold");
                break;

            case "GG157":
                PlayerPrefs.SetString("mic6", "isSold");
                break;

            case "방송용 마이크":
                PlayerPrefs.SetString("mic7", "isSold");
                break;

            case "아이돌이 쓸 법한 마이크":
                PlayerPrefs.SetString("mic8", "isSold");
                break;

            case "Shiba's VoicE":
                PlayerPrefs.SetString("mic9", "isSold");
                break;

            case "스튜디오 마이크":
                PlayerPrefs.SetString("mic10", "isSold");
                break;

            case "The Angel's Ring":
                PlayerPrefs.SetString("mic11", "isSold");
                break;

            case "목소리":
                PlayerPrefs.SetString("mic12", "isSold");
                break;
        }
        CheckData();
    }

    public void CheckData()
    {
        if (PlayerPrefs.GetString("mic2") == "isSold" && gameObject.transform == contents.transform.GetChild(0))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("mic3") == "isSold" && gameObject.transform == contents.transform.GetChild(1))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("mic4") == "isSold" && gameObject.transform == contents.transform.GetChild(2))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("mic5") == "isSold" && gameObject.transform == contents.transform.GetChild(3))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }
        if (PlayerPrefs.GetString("mic6") == "isSold" && gameObject.transform == contents.transform.GetChild(4))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }
        if (PlayerPrefs.GetString("mic7") == "isSold" && gameObject.transform == contents.transform.GetChild(5))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("mic8") == "isSold" && gameObject.transform == contents.transform.GetChild(6))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("mic9") == "isSold" && gameObject.transform == contents.transform.GetChild(7))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("mic10") == "isSold" && gameObject.transform == contents.transform.GetChild(8))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("mic11") == "isSold" && gameObject.transform == contents.transform.GetChild(9))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }
        if (PlayerPrefs.GetString("mic12") == "isSold" && gameObject.transform == contents.transform.GetChild(10))
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
        micImage.sprite = micSprite;
        popularText.text = string.Format("{0}", popular);
    }

    public void ChooseBuy()
    {
        int productMoney;
        string productName;
        int productPopular;
        productMoney = int.Parse(moneyText.text);
        productName = nameText.text;
        productPopular = int.Parse(popularText.text);

        Debug.Log(productMoney);

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

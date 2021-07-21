using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicButtons : MonoBehaviour
{
    private string btnName;
    private int money;
    private int popular;
    private int moneyPS;
    private Sprite musicSprite;
    private string info;

    private bool isBuy = false;

    public Music music;
    private int originPopular;

    [SerializeField]
    GameObject BuyPopup;
    [SerializeField]
    Text nameText, infoText, detailText, moneyText;
    [SerializeField]
    Image musicImage, buttonImage;
    [SerializeField]
    Sprite isSold, isEnabled;
    [SerializeField]
    GameObject contents;

    void Start()
    {
        SetUpData();
    }

    public void Setup(Music music)
    {
        this.music = music;
        this.btnName = music.musicName;
        this.money = music.money;
        this.popular = music.popular;
        this.moneyPS = music.moneyPerSec;
        this.musicSprite = music.musicSprite;
        this.info = music.info;
    }

    private void SetUpData()
    {
        switch (btnName)
        {
            case "봄":
                PlayerPrefs.GetString("music1", "isSell");
                break;

            case "Nighty Night":
                PlayerPrefs.GetString("music2", "isSell");
                break;

            case "SUMMER STORM!":
                PlayerPrefs.GetString("music3", "isSell");
                break;

            case "모험":
                PlayerPrefs.GetString("music4", "isSell");
                break;

            case "평화로운 마을":
                PlayerPrefs.GetString("music5", "isSell");
                break;

            case "Bell tower":
                PlayerPrefs.GetString("music6", "isSell");
                break;

            case "Error":
                PlayerPrefs.GetString("music7", "isSell");
                break;

            case "Exploration":
                PlayerPrefs.GetString("music8", "isSell");
                break;

            case "Happy memories":
                PlayerPrefs.GetString("music9", "isSell");
                break;

            case "Lawn":
                PlayerPrefs.GetString("music10", "isSell");
                break;

            case "Night walk":
                PlayerPrefs.GetString("music11", "isSell");
                break;

            case "Recess":
                PlayerPrefs.GetString("music12", "isSell");
                break;

            case "Unknown":
                PlayerPrefs.GetString("music13", "isSell");
                break;

            case "Whirlpool":
                PlayerPrefs.GetString("music14", "isSell");
                break;
        }
        CheckData();
    }

    private void ChangeData(string productName)
    {
        switch (productName)
        {
            case "봄":
                PlayerPrefs.SetString("music1", "isSold");
                break;

            case "Nighty Night":
                PlayerPrefs.SetString("music2", "isSold");
                Debug.Log("나이티");
                break;

            case "SUMMER STORM!":
                PlayerPrefs.SetString("music3", "isSold");
                Debug.Log("썸머");
                break;

            case "모험":
                PlayerPrefs.SetString("music4", "isSold");
                break;

            case "평화로운 마을":
                PlayerPrefs.SetString("music5", "isSold");
                break;

            case "Bell tower":
                PlayerPrefs.SetString("music6", "isSold");
                break;

            case "Error":
                PlayerPrefs.SetString("music7", "isSold");
                break;

            case "Exploration":
                PlayerPrefs.SetString("music8", "isSold");
                break;

            case "Happy memories":
                PlayerPrefs.SetString("music9", "isSold");
                break;

            case "Lawn":
                PlayerPrefs.SetString("music10", "isSold");
                break;

            case "Night walk":
                PlayerPrefs.SetString("music11", "isSold");
                break;

            case "Recess":
                PlayerPrefs.SetString("music12", "isSold");
                break;

            case "Unknown":
                PlayerPrefs.SetString("music13", "isSold");
                break;

            case "Whirlpool":
                PlayerPrefs.SetString("music14", "isSold");
                break;
        }
        CheckData();
    }

    public void CheckData()
    {
        if (PlayerPrefs.GetString("music1") == "isSold" && gameObject.transform == contents.transform.GetChild(0))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music2") == "isSold" && gameObject.transform == contents.transform.GetChild(1))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music3") == "isSold" && gameObject.transform == contents.transform.GetChild(2))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music4") == "isSold" && gameObject.transform == contents.transform.GetChild(3))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music5") == "isSold" && gameObject.transform == contents.transform.GetChild(4))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music6") == "isSold" && gameObject.transform == contents.transform.GetChild(5))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music7") == "isSold" && gameObject.transform == contents.transform.GetChild(6))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music8") == "isSold" && gameObject.transform == contents.transform.GetChild(7))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music9") == "isSold" && gameObject.transform == contents.transform.GetChild(8))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music10") == "isSold" && gameObject.transform == contents.transform.GetChild(9))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music11") == "isSold" && gameObject.transform == contents.transform.GetChild(10))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music12") == "isSold" && gameObject.transform == contents.transform.GetChild(11))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music13") == "isSold" && gameObject.transform == contents.transform.GetChild(12))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("music14") == "isSold" && gameObject.transform == contents.transform.GetChild(13))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (musicSprite == null)
        {
            buttonImage.sprite = isEnabled;
        }
    }

    public void OnClickBuy()
    {
        if (isBuy) return;
        BuyPopup.SetActive(true);
        SoundManager.instance.PlayMusic(btnName);

        nameText.text = string.Format("{0}", btnName);
        infoText.text = string.Format("{0}", info);
        detailText.text = string.Format("5초당 획득 돈: {0}원\n인기도 +{1}원", moneyPS, popular);
        moneyText.text = string.Format("{0}", money);
        musicImage.sprite = musicSprite;
    }

    public void ChooseBuy()
    {
        int productMoney;
        string productName;
        productMoney = int.Parse(moneyText.text);
        productName = nameText.text;

        if (GameManager.Instance.playerMoney - productMoney <= 0)
        {
            SoundManager.instance.ErrorSound();
            return;
        }

        BuyPopup.SetActive(false);

        GameManager.Instance.Min(productMoney);
        originPopular += popular;
        PlayerPrefs.SetInt("p1", originPopular);

        ChangeData(productName);
        CheckData();
        GameManager.Instance.UpdateUI();
        SoundManager.instance.PlayMusic(PlayerPrefs.GetString("pmusic", "A Little Ghost"));
        SoundManager.instance.CashSound();
    }
}
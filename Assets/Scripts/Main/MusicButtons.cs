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
            case "º½":
                PlayerPrefs.GetString("music1", "isSell");
                break;

            case "Nighty Night":
                PlayerPrefs.GetString("music2", "isSell");
                break;

            case "SUMMER STORM!":
                PlayerPrefs.GetString("music3", "isSell");
                break;

            case "¾îÂ¼±¸":
                PlayerPrefs.GetString("music4", "isSell");
                break;

            case "ÀúÂ¼±¸":
                PlayerPrefs.GetString("music5", "isSell");
                break;
        }
        CheckData();
    }

    private void ChangeData(string productName)
    {
        switch (productName)
        {
            case "º½":
                PlayerPrefs.SetString("music1", "isSold");
                break;

            case "Nighty Night":
                PlayerPrefs.SetString("music2", "isSold");
                Debug.Log("³ªÀÌÆ¼");
                break;

            case "SUMMER STORM!":
                PlayerPrefs.SetString("music3", "isSold");
                Debug.Log("½æ¸Ó");

                break;

            case "¾îÂ¼±¸":
                PlayerPrefs.SetString("music4", "isSold");
                break;

            case "ÀúÂ¼±¸":
                PlayerPrefs.SetString("music5", "isSold");
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

        if(musicSprite == null)
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
        detailText.text = string.Format("5ÃÊ´ç È¹µæ µ·: {0}¿ø\nÀÎ±âµµ +{1}¿ø", moneyPS, popular);
        moneyText.text = string.Format("{0}", money);
        musicImage.sprite = musicSprite;
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
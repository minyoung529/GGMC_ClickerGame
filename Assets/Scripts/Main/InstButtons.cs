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
    GameObject BuyPopup;
    [SerializeField]
    Text nameText, infoText, detailText, moneyText;
    [SerializeField]
    Image instImage, buttonImage;
    [SerializeField]
    Sprite isSold;
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
            case "�ƹ���":
                PlayerPrefs.GetString("inst11", "isSell");
                break;

            case "��Ÿ":
                PlayerPrefs.GetString("inst22", "isSell");
                break;

            case "�Ϸ� ��Ÿ":
                PlayerPrefs.GetString("inst33", "isSell");
                break;

            case "������ �ǾƳ�":
                PlayerPrefs.GetString("inst44", "isSell");
                break;

            case "�ŵ������":
                PlayerPrefs.GetString("inst55", "isSell");
                break;

            case "�巳":
                PlayerPrefs.GetString("inst66", "isSell");
                break;
        }
        CheckData();
    }

    private void ChangeData(string productName)
    {
        switch (productName)
        {
            case "�ƹ���":
                PlayerPrefs.SetString("inst11", "isSold");
                break;

            case "��Ÿ":
                PlayerPrefs.SetString("inst22", "isSold");
                break;

            case "�Ϸ� ��Ÿ":
                PlayerPrefs.SetString("inst33", "isSold");
                break;

            case "������ �ǾƳ�":
                PlayerPrefs.SetString("inst44", "isSold");
                break;

            case "�ŵ������":
                PlayerPrefs.SetString("inst55", "isSold");
                break;

            case "�巳":
                PlayerPrefs.SetString("inst66", "isSold");
                break;
        }

        Debug.Log(PlayerPrefs.GetString("inst11"));
        CheckData();
    }

    private void CheckData()
    {
        if (PlayerPrefs.GetString("inst11") == "isSold" && gameObject.transform == contents.transform.GetChild(0))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst22") == "isSold" && gameObject.transform == contents.transform.GetChild(1))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst33") == "isSold" && gameObject.transform == contents.transform.GetChild(2))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst44") == "isSold" && gameObject.transform == contents.transform.GetChild(3))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }

        if (PlayerPrefs.GetString("inst55") == "isSold" && gameObject.transform == contents.transform.GetChild(4))
        {
            buttonImage.sprite = isSold;
            isBuy = true;
        }
        if (PlayerPrefs.GetString("inst66") == "isSold" && gameObject.transform == contents.transform.GetChild(5))
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
        detailText.text = string.Format("5�ʴ� ȹ�� ��: {0}��\n�α⵵ +{1}��", moneyPS, popular);
        moneyText.text = string.Format("{0}", money);
        instImage.sprite = instSprite;
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
        GameManager.Instance.UpdateUI();

        ChangeData(productName);
        CheckData();
    }
}

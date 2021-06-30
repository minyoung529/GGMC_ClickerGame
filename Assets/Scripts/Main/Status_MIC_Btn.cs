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
        if (btnName == "다이나믹 마이크" && PlayerPrefs.GetString("mic1") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "GG157" && PlayerPrefs.GetString("mic2") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "콘덴서 마이크" && PlayerPrefs.GetString("mic3") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "인이어 마이크" && PlayerPrefs.GetString("mic4") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "마이스트로" && PlayerPrefs.GetString("mic5") == "isSold")
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
        if (btnImage.sprite == micEnabled) return;
        choosePopup.SetActive(false);

        PlayerPrefs.SetString("pm", btnName);
        PlayerPrefs.SetInt("mtm", moneyPS);
        GameManager.Instance.UpdateUI();
    }
}

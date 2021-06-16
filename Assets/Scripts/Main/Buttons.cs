using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    #region º¯¼ö
    [SerializeField]
    private Image image;
    [SerializeField]
    private Image buttonImage;

    private int level = 0;
    private int click;
    private int money;
    private int number;
    private string btnName;
    private int plusMoney;

    [SerializeField]
    private Text levelText;
    [SerializeField]
    private Text percentText;
    [SerializeField]
    private Text clickText;
    [SerializeField]
    private Text moneyText;
    [SerializeField]
    private Text nameText;
    private ClickArea ca = null;

    private int oneClickMoney;

    public MainButtonData mainButtonData;
    #endregion

    private void Start()
    {
        ca = FindObjectOfType<ClickArea>();
        oneClickMoney = PlayerPrefs.GetInt("test1");
    }

    private void OnMouseDown()
    {
        Lock();
    }

    public void Setup(MainButtonData mainButtonData)
    {
        this.mainButtonData = mainButtonData;
        image.sprite = mainButtonData.sprite;
        this.level = mainButtonData.level;
        this.click = mainButtonData.click;
        this.money = mainButtonData.money;
        this.number = mainButtonData.number;
        this.btnName = mainButtonData.name;
        this.plusMoney = mainButtonData.plusMoney;

        levelText.text = string.Format("Level {0}", level);
        //percentText.text = string.Format("{0}%", percent);
        clickText.text = string.Format("click+{0}", number);
        moneyText.text = string.Format("{0}¿ø", money);
        nameText.text = string.Format("{0}", btnName);
        image.color = new Color(1f, 1f, 1f, 1f);
    }

    public void Lock()
    {
        if (PlayerPrefs.GetInt("Money") < money)
        {
            buttonImage.color = new Color(0f, 0f, 0f, 0.5f);
            image.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }

        else
            buttonImage.color = new Color(0.5f, 0.5f, 0.5f, 1f);
    }

    public void Rhythm()
    {
        if (GameManager.Instance.playerMoney - mainButtonData.money < 0) return;

        GameManager.Instance.Min(money);

        mainButtonData.money += plusMoney;
        mainButtonData.level += 1;
        mainButtonData.number += click;

        PlusOnClickMoney(click);

        Setup(this.mainButtonData);
    }

    private void PlusOnClickMoney(int clickCount)
    {
        oneClickMoney += clickCount;
        PlayerPrefs.SetInt("test1", oneClickMoney);
        GameManager.Instance.UpdateUI();
    }
}

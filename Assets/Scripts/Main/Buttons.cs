using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    #region 변수
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
        SetPrefs(PlayerPrefs.GetString("Test1"));
        Debug.Log(money);

        SetButtonText();
    }

    private void OnMouseDown()
    {
        Lock();
    }

    public void Setup(MainButtonData mainButtonData)
    {
        this.mainButtonData = mainButtonData;
        image.sprite = mainButtonData.sprite;
        this.btnName = mainButtonData.name;

        this.plusMoney = mainButtonData.plusMoney;
        this.click = mainButtonData.click;
    }

    private void SetButtonText()
    {
        levelText.text = string.Format("Level {0}", level);
        clickText.text = string.Format("click+{0}", number);
        moneyText.text = string.Format("{0}원", money);
        image.color = new Color(1f, 1f, 1f, 1f);
    }

    private void SaveData_MainBtn()
    {
        switch (btnName)
        {
            case "리듬감":
                PlayerPrefs.SetString("Test1", InsertData(level, money, number));
                SetPrefs(PlayerPrefs.GetString("Test1"));
                break;

            case "연주 실력":
                PlayerPrefs.SetString("Test2", InsertData(level, money, number));
                SetPrefs(PlayerPrefs.GetString("Test2"));
                break;
        }
    }

    private string InsertData(int level, int money, int number)
    {
        int[] data = new int[3];

        data[0] = level;
        data[1] = money;
        data[2] = number;

        string strArr = "";

        for(int i = 0; i < 3; i++)
        {
            strArr = strArr + data[i];

            if(i < 2)
            {
                strArr = strArr + ',';
            }
        }

        return strArr;
    }

    private void SetPrefs(string playerPrefs)
    {
        string[] dataArr = playerPrefs.Split(',');
        int[] data = new int[3];

        for(int i = 0; i < 3; i++)
        {
            data[i] = Convert.ToInt32(dataArr[i]);
        }

        level = data[0];
        money = data[1];
        number = data[2];
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
        if (GameManager.Instance.playerMoney - money < 0) return;

        GameManager.Instance.Min(money);

        money += plusMoney;
        level++;
        number += click;

        SaveData_MainBtn();
        PlusOnClickMoney(click);
        SetButtonText();
    }

    private void PlusOnClickMoney(int clickCount)
    {
        oneClickMoney += clickCount;
        PlayerPrefs.SetInt("test1", oneClickMoney);
        GameManager.Instance.UpdateUI();
    }
}
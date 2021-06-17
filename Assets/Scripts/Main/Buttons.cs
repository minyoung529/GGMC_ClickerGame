using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    #region ����
    [SerializeField]
    private Image image;
    [SerializeField]
    private Image buttonImage;

    private int level = 1;
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

    private int oneClickMoney;

    public MainButtonData mainButtonData;
    #endregion

    private void Start()
    {
        oneClickMoney = PlayerPrefs.GetInt("test1");

        Setup(mainButtonData);
        SetUpData();
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
        moneyText.text = string.Format("{0}��", money);
        image.color = new Color(1f, 1f, 1f, 1f);
    }

    private void SaveData_MainBtn()
    {
        switch (btnName)
        {
            case "���밨":
                PlayerPrefs.SetString("Test1", InsertData(level, money, number));
                SetPrefs(PlayerPrefs.GetString("Test1"));
                break;

            case "���� �Ƿ�":
                PlayerPrefs.SetString("Test2", InsertData(level, money, number));
                SetPrefs(PlayerPrefs.GetString("Test2"));
                break;

            case "�߼���":
                PlayerPrefs.SetString("Test3", InsertData(level, money, number));
                SetPrefs(PlayerPrefs.GetString("Test3"));
                break;

            case "��Ȱ��":
                PlayerPrefs.SetString("Test4", InsertData(level, money, number));
                SetPrefs(PlayerPrefs.GetString("Test4"));
                break;

            case "������ ��ȭ":
                PlayerPrefs.SetString("Test5", InsertData(level, money, number));
                SetPrefs(PlayerPrefs.GetString("Test5"));
                break;
        }
    }

    private void SetUpData()
    {
        if (gameObject.CompareTag("Rhythm"))
        {
            SetPrefs(PlayerPrefs.GetString("Test1", "1,5,1"));
        }

        else if (gameObject.CompareTag("Instrument"))
        {
            SetPrefs(PlayerPrefs.GetString("Test2", "1,35,5"));
        }

        else if (gameObject.CompareTag("Vocalization"))
        {
            SetPrefs(PlayerPrefs.GetString("Test3", "1,80,10"));
        }

        else if (gameObject.CompareTag("Breathing"))
        {
            SetPrefs(PlayerPrefs.GetString("Test4", "1,560,50"));
        }

        else if (gameObject.CompareTag("Pitch"))
        {
            SetPrefs(PlayerPrefs.GetString("Test5", "1,1120,100"));
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

    public void Buy()
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
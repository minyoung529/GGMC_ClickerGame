﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private MainButtonManager mainButtonManager;

    [Header("텍스트")]
    [SerializeField]
    private Text moneyText;
    [SerializeField]
    private Text statusText;
    [SerializeField]
    private Text oneClickText;

    [Header("메뉴 이미지")]
    [SerializeField]
    private GameObject mainImage;
    [SerializeField]
    public GameObject statusImage;
    [SerializeField]
    private GameObject storeImage;
    [SerializeField]
    private GameObject settingImage;

    [Header("버튼 오브젝트")]
    [SerializeField]
    private GameObject mainBtn;
    [SerializeField]
    private GameObject statusBtn;
    [SerializeField]
    private GameObject storeBtn;
    [SerializeField]
    private GameObject settingBtn;

    private Image mainBtnimage, statusBtnimage, storeBtnimage, settingBtnimage;

    private List<GameObject> btnImages = new List<GameObject>();
    private List<Image> btnObjs = new List<Image>();

    public int oneClickMoney;
    public int playerMoney;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        mainButtonManager = FindObjectOfType<MainButtonManager>();
        playerMoney = PlayerPrefs.GetInt("Money");
        oneClickMoney = PlayerPrefs.GetInt("test1");
        UpdateUI();
        SetBtnList();
    }

    public void UpdateUI()
    {
        oneClickMoney = PlayerPrefs.GetInt("test1");

        moneyText.text = string.Format("₩:{0}원", playerMoney);
        statusText.text = string.Format("이름: 이미녕\n자본금: {0}원\n악기:는 거꾸로해도 기악\n현재상태: 거지음악가", playerMoney);
        oneClickText.text = string.Format("Click-{0}", oneClickMoney);
    }

    public void AddMoney(int addScore)
    {
        playerMoney += addScore;
        PlayerPrefs.SetInt("Money", playerMoney);
        UpdateUI();
    }

    public void OnClickMain()
    {
        BtnActive(mainImage);
    }

    public void OnClickStatus()
    {
        BtnActive(statusImage);
    }

    public void OnClickStore()
    {
        BtnActive(storeImage);
    }

    public void OnClickSetting()
    {
        BtnActive(settingImage);
    }

    private void BtnActive(GameObject image)
    {
        for (int i = 0; i < btnImages.Count; i++)
        {
            if (image == btnImages[i])
            {
                btnImages[i].SetActive(true);
                btnObjs[i].color = new Color(0.8f, 0.8f, 0.8f, 1f);
            }
            else
            {
                btnImages[i].SetActive(false);
                btnObjs[i].color = new Color(1f, 1f, 1f, 1f);
            }
        }
    }

    private void SetBtnList()
    {
        SetBtnGetComponent();

        btnImages.Add(mainImage);
        btnImages.Add(storeImage);
        btnImages.Add(statusImage);
        btnImages.Add(settingImage);

        btnObjs.Add(mainBtnimage);
        btnObjs.Add(storeBtnimage);
        btnObjs.Add(statusBtnimage);
        btnObjs.Add(settingBtnimage);
    }

    private void SetBtnGetComponent()
    {
        mainBtnimage = mainBtn.GetComponent<Image>();
        statusBtnimage = statusBtn.GetComponent<Image>();
        storeBtnimage = storeBtn.GetComponent<Image>();
        settingBtnimage = settingBtn.GetComponent<Image>();
    }

    public void Min(int minmoney)
    {
        playerMoney -= minmoney;
        //Debug.Log(money);
        mainButtonManager.SetUp_MainBtns();
        UpdateUI();
    }
}
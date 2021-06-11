using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("텍스트")]
    [SerializeField]
    private Text moneyText;

    [Header("메뉴 이미지")]
    [SerializeField]
    private GameObject mainImage;
    [SerializeField]
    private GameObject statusImage;
    [SerializeField]
    private GameObject storeImage;
    [SerializeField]
    private GameObject settingImage;

    private bool isClick = false;
    public int money { get; private set; } = 0;
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        money = PlayerPrefs.GetInt("Money", 0);
        UpdateUI();
    }

    public void UpdateUI()
    {
        moneyText.text = string.Format("{0}원", money);
    }

    public void AddMoney(int addScore)
    {
        money += addScore;
        PlayerPrefs.SetInt("Money", money);
        UpdateUI();
    }

    public void OnClickMain()
    {
        statusImage.SetActive(false);
        storeImage.SetActive(false);
        settingImage.SetActive(false);

        mainImage.SetActive(true);
    }

    public void OnClickStatus()
    {
        mainImage.SetActive(false);
        storeImage.SetActive(false);
        settingImage.SetActive(false);

        statusImage.SetActive(true);
    }

    public void OnClickStore()
    {
        statusImage.SetActive(false);
        mainImage.SetActive(false);
        settingImage.SetActive(false);

        storeImage.SetActive(true);
    }

    public void OnClickSetting()
    {
        statusImage.SetActive(false);
        storeImage.SetActive(false);
        mainImage.SetActive(false);

        settingImage.SetActive(true);
    }
}

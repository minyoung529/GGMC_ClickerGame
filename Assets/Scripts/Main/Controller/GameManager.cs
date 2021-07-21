﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region
    public static GameManager Instance;
    public Player player;
    public string playerInstrument;

    [Header("텍스트")]
    [SerializeField]
    private Text moneyText, timeText, statusText, oneClickText, plusMoneyText, playerStatusText;

    [SerializeField]
    Camera mainCamera, statusCamera, storeCamera, settingCamera;

    [SerializeField]
    private GameObject coinPrefab;

    [Header("버튼 오브젝트")]
    [SerializeField]
    private GameObject mainBtn;
    [SerializeField]
    private GameObject statusBtn;
    [SerializeField]
    private GameObject storeBtn;
    [SerializeField]
    private GameObject settingBtn;

    [Header("스토어")]
    [SerializeField]
    private GameObject buyPopupImage;
    [SerializeField]
    private GameObject buyMICPopupImage;
    [SerializeField]
    private GameObject buyMusicPopupImage;

    [Header("내 정보")]
    [SerializeField]
    private GameObject instPanel;
    [SerializeField]
    private GameObject micPanel;
    [SerializeField]
    private GameObject musicPanel;
    [SerializeField]
    private GameObject buttonsParent;
    [SerializeField]
    private GameObject choosePopup;

    private StatusPlayerInst statusPlayerInst;
    private MainPlayerInst mainPlayerInst;
    private StatusPlayerMIC statusPlayerMIC;
    private MainPlayerMIC mainPlayerMIC;
    private StatusPlayerMusic statusPlayerMusic;

    [SerializeField]
    private Image mainBtnimage, statusBtnimage, storeBtnimage, settingBtnimage;
    [SerializeField]
    private Canvas main, status, store, setting;

    private List<Image> btnObjs = new List<Image>();

    private int oneClickMoney;
    public int playerMoney;
    private int popular;
    private int timeMoney;
    private string playerStatus = "거지음악가";
    private string playerMusic;

    private float timer = 0;
    #endregion

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Screen.SetResolution(1440, 2960, true);
        player = FindObjectOfType<Player>();
        statusPlayerInst = FindObjectOfType<StatusPlayerInst>();
        mainPlayerInst = FindObjectOfType<MainPlayerInst>();
        statusPlayerMIC = FindObjectOfType<StatusPlayerMIC>();
        mainPlayerMIC = FindObjectOfType<MainPlayerMIC>();
        statusPlayerMusic = FindObjectOfType<StatusPlayerMusic>();

        timeMoney = PlayerPrefs.GetInt("tm", 1);
        playerMoney = PlayerPrefs.GetInt("Money", 0);
        oneClickMoney = PlayerPrefs.GetInt("onc2", 1);
        popular = PlayerPrefs.GetInt("p1", 0);
        playerInstrument = PlayerPrefs.GetString("pi", "캐스터네츠");
        playerMusic = PlayerPrefs.GetString("pmusic", "A Little Ghost");
        SetBtnList();
        UpdateUI();

        OnClickMain();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddMoney(100000);
        }

        TimePerMoney();
    }

    public void UpdateUI()
    {
        oneClickMoney = PlayerPrefs.GetInt("onc2", 1);
        timeMoney = PlayerPrefs.GetInt("micPS", 0) + PlayerPrefs.GetInt("instPS", 1) + PlayerPrefs.GetInt("musicPS", 1);
        playerInstrument = PlayerPrefs.GetString("pi", "캐스터네츠");
        popular = PlayerPrefs.GetInt("p1", 0);

        ChangeSprite();
        PlayerStatus();

        playerStatusText.text = string.Format("{0}", playerStatus);
        moneyText.text = string.Format("₩:{0}원", playerMoney);
        statusText.text = string.Format("이름: 이미녕\n클릭당 획든 돈: {0}원\n5초당 획든 돈: {1}원\n자본금: {2}원\n인기도: {3}", oneClickMoney, timeMoney, playerMoney, popular/*, playerStatus*/);
        oneClickText.text = string.Format("Click-{0}", oneClickMoney);
        timeText.text = string.Format("5Sec-{0}", timeMoney);
    }

    private void PlayerStatus()
    {
        if (playerMoney < 100000)
        {
            playerStatus = "거지음악가";
        }

        else if (playerMoney < 500000)
        {
            playerStatus = "뒷골목음악가";
        }

        else if (playerMoney < 1000000)
        {
            playerStatus = "뒷골목 주름잡는 음악가";
        }

        else if (playerMoney < 10000000)
        {
            playerStatus = "여엇한 음악가";
        }

        else if (playerMoney < 15000000)
        {
            playerStatus = "당당한 음악가";
        }

        else if (playerMoney < 30000000)
        {
            playerStatus = "짱쎈 음악가";
        }

        else
        {
            playerStatus = "톱스타";
        }
    }

    public void AddMoney(int addMoney)
    {
        playerMoney += addMoney;
        PlayerPrefs.SetInt("Money", playerMoney);
        UpdateUI();
    }

    private void ChangeSprite()
    {
        statusPlayerInst.ChangeSprite();
        mainPlayerInst.ChangeSprite();
        statusPlayerMIC.ChangeSprite();
        mainPlayerMIC.ChangeSprite();
        statusPlayerMusic.ChangeSprite();
    }

    private void PlayerMusic()
    {
        playerMusic = PlayerPrefs.GetString("pmusic", "A Little Ghost");

        if (buyMusicPopupImage.activeSelf)
        {
            buyMusicPopupImage.SetActive(false);
            SoundManager.instance.PlayMusic(playerMusic);
        }

        buyMICPopupImage.SetActive(false);
        buyPopupImage.SetActive(false);
    }

    private void SetActiveCamera(bool isTrue)
    {
        if (!isTrue)
        {
            mainCamera.gameObject.SetActive(false);
            statusCamera.gameObject.SetActive(false);
            storeCamera.gameObject.SetActive(false);
            settingCamera.gameObject.SetActive(false);
        }
    }

    private void SetActiveCanvas(bool isTrue)
    {
        if (!isTrue)
        {
            main.gameObject.SetActive(false);
            status.gameObject.SetActive(false);
            store.gameObject.SetActive(false);
            setting.gameObject.SetActive(false);
        }
    }

    public void OnClickMain()
    {
        PlayerMusic();
        MainButton(main, mainCamera, mainBtnimage);

        player.PlayerActive();
    }

    public void OnClickStatus()
    {
        PlayerMusic();
        MainButton(status, statusCamera, statusBtnimage);

        player.PlayerInactive();
    }

    public void OnClickStore()
    {
        MainButton(store, storeCamera, storeBtnimage);
        player.PlayerInactive();
    }

    public void OnClickSetting()
    {
        PlayerMusic();

        MainButton(setting, settingCamera, settingBtnimage);
        player.PlayerInactive();
    }

    public void MainButton(Canvas mainImage, Camera camera, Image btnImage)
    {
        SetActiveCamera(false);
        SetActiveCanvas(false);
        AllBtnSetColor();
        SetButtonColor(btnImage);
        mainImage.gameObject.SetActive(true);
        camera.gameObject.SetActive(true);
    }

    public void InactiveChoosePopup()
    {
        choosePopup.SetActive(false);
    }
    public void OnClickAudition()
    {
        SceneManager.LoadScene("Audition");
    }

    private void SetBtnList()
    {
        btnObjs.Add(mainBtnimage);
        btnObjs.Add(storeBtnimage);
        btnObjs.Add(statusBtnimage);
        btnObjs.Add(settingBtnimage);
    }

    public void AllBtnSetColor()
    {
        mainBtnimage.color = Color.white;
        storeBtnimage.color = Color.white;
        statusBtnimage.color = Color.white;
        settingBtnimage.color = Color.white;
    }

    public void SetButtonColor(Image button)
    {
        button.color = Color.gray;
    }

    public void Min(int minmoney)
    {
        playerMoney -= minmoney;
        UpdateUI();
        PlayerPrefs.SetInt("Money", playerMoney);
    }

    public void BuyPopupActive()
    {
        if (buyMusicPopupImage.activeSelf)
        {
            SoundManager.instance.StopMusic();
        }

        buyPopupImage.SetActive(false);
        buyMICPopupImage.SetActive(false);
        buyMusicPopupImage.SetActive(false);
    }

    public void ClickArea()
    {
        oneClickMoney = PlayerPrefs.GetInt("onc2", 1);
        AddMoney(oneClickMoney);

        UpdateUI();
    }

    public void InstPanel(string panelName)
    {
        for (int i = 0; i < buttonsParent.transform.childCount; i++)
        {
            buttonsParent.transform.GetChild(i).GetComponentInChildren<Image>().color = Color.white;
        }

        if (panelName == "악기")
        {
            instPanel.SetActive(true);
            micPanel.SetActive(false);
            musicPanel.SetActive(false);
            buttonsParent.transform.GetChild(0).GetComponentInChildren<Image>().color = new Color32(255, 245, 184, 255);
        }

        else if (panelName == "마이크")
        {
            instPanel.SetActive(false);
            micPanel.SetActive(true);
            musicPanel.SetActive(false);
            buttonsParent.transform.GetChild(1).GetComponentInChildren<Image>().color = new Color32(255, 245, 184, 255);
        }

        else if (panelName == "음악")
        {
            instPanel.SetActive(false);
            micPanel.SetActive(false);
            musicPanel.SetActive(true);
            buttonsParent.transform.GetChild(2).GetComponentInChildren<Image>().color = new Color32(255, 245, 184, 255);
        }

    }

    public void StatusInst_ChangeSprite()
    {
        statusPlayerInst.ChangeSprite();
    }

    private void TimePerMoney()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            if (main.gameObject.activeSelf && timeMoney > 4)
            {
                StartCoroutine(PlusMoney());
            }

            AddMoney(timeMoney);
            timer = 0;
        }
    }

    IEnumerator PlusMoney()
    {
        float randomX;

        for (int i = 0; i < timeMoney / 5; i++)
        {
            randomX = Random.Range(-20.3f, -19.6f);
            Instantiate(coinPrefab);
            coinPrefab.gameObject.transform.position = new Vector2(randomX, 4f);
            yield return new WaitForSeconds(0.01f);
        }

        SoundManager.instance.CashSound();
        yield break;
    }
}
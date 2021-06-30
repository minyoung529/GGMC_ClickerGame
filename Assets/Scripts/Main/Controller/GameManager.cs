using System.Collections;
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
    private Text moneyText, timeText, statusText, oneClickText, plusMoneyText;

    [SerializeField]
    Camera mainCamera;

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

    [Header("내 정보")]
    [SerializeField]
    private GameObject instPanel;
    [SerializeField]
    private GameObject micPanel;

    private StatusPlayerInst statusPlayerInst;
    private MainPlayerInst mainPlayerInst;

    [SerializeField]
    private Image mainBtnimage, statusBtnimage, storeBtnimage, settingBtnimage;

    private List<GameObject> btnImages = new List<GameObject>();
    private List<Image> btnObjs = new List<Image>();

    private int oneClickMoney;
    private int clickCnt = 0;
    public int playerMoney;
    private int popular;
    private int timeMoney;

    private float timer = 0;
    #endregion

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        player = FindObjectOfType<Player>();
        statusPlayerInst = FindObjectOfType<StatusPlayerInst>();
        mainPlayerInst = FindObjectOfType<MainPlayerInst>();

        timeMoney = PlayerPrefs.GetInt("tm", 1);
        playerMoney = PlayerPrefs.GetInt("Money", 0);
        oneClickMoney = PlayerPrefs.GetInt("onc2", 1);
        popular = PlayerPrefs.GetInt("p1", 0);
        playerInstrument = PlayerPrefs.GetString("pi", "캐스터네츠");
        SetBtnList();
        UpdateUI();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddMoney(10000);
        }

        TimePerMoney();
    }

    public void UpdateUI()
    {
        Debug.Log("sd");
        oneClickMoney = PlayerPrefs.GetInt("onc2", 1);
        timeMoney = PlayerPrefs.GetInt("tm", 1);
        playerInstrument = PlayerPrefs.GetString("pi", "캐스터네츠");

        statusPlayerInst.ChangeSprite();
        mainPlayerInst.ChangeSprite();

        moneyText.text = string.Format("₩:{0}원", playerMoney);
        statusText.text = string.Format("이름: 이미녕\n클릭당 획든 돈: {0}원\n초당 획든 돈:{1}원\n자본금: {2}원\n악기:는 거꾸로해도 기악\n현재상태: 거지음악가\n인기도:{3}", oneClickMoney, timeMoney, playerMoney, popular);
        oneClickText.text = string.Format("Click-{0}", oneClickMoney);
        timeText.text = string.Format("5Sec-{0}", timeMoney);
    }

    public void AddMoney(int addMoney)
    {
        playerMoney += addMoney;
        PlayerPrefs.SetInt("Money", playerMoney);
        UpdateUI();
    }

    public void OnClickMain()
    {
        if (clickCnt == 2005)
            moneyText.text = string.Format("유하준 왔다감");
        mainCamera.transform.position = new Vector2(-20f, 0f);
        player.PlayerActive();
        clickCnt++;
    }

    public void OnClickStatus()
    {
        mainCamera.transform.position = new Vector2(-15f, 0f);
        player.PlayerInactive();
        clickCnt *= 2;
    }

    public void OnClickStore()
    {
        mainCamera.transform.position = new Vector2(-10f, 0f);
        player.PlayerInactive();
        clickCnt *= 2;
    }

    public void OnClickSetting()
    {
        mainCamera.transform.position = new Vector2(-5f, 0f);
        player.PlayerInactive();
        clickCnt += 1000;
    }

    public void OnClickAudition()
    {
        SceneManager.LoadScene("Audition");
    }

    private void BtnActive(GameObject image)
    {
        for (int i = 0; i < btnImages.Count; i++)
        {
            if (image == btnImages[i])
                btnObjs[i].color = new Color(0.8f, 0.8f, 0.8f, 1f);
            else
                btnObjs[i].color = new Color(1f, 1f, 1f, 1f);
        }
    }

    private void SetBtnList()
    {
        btnObjs.Add(mainBtnimage);
        btnObjs.Add(storeBtnimage);
        btnObjs.Add(statusBtnimage);
        btnObjs.Add(settingBtnimage);
    }

    public void Min(int minmoney)
    {
        playerMoney -= minmoney;
        UpdateUI();
        PlayerPrefs.SetInt("Money", playerMoney);
    }

    public void buyPopupActive()
    {
        buyPopupImage.SetActive(false);
    }

    public void ClickArea()
    {
        oneClickMoney = PlayerPrefs.GetInt("onc2", 1);
        AddMoney(oneClickMoney);

        UpdateUI();
    }

    public void InstPanel()
    {
        instPanel.SetActive(true);
        micPanel.SetActive(false);
    }

    public void MICPanel()
    {
        micPanel.SetActive(true);
        instPanel.SetActive(false);
    }

    public void statusInst_ChangeSprite()
    {
        statusPlayerInst.ChangeSprite();
    }

    private void TimePerMoney()
    {
        timeMoney = PlayerPrefs.GetInt("tm", 1);

        timer += Time.deltaTime;
        if (timer >= 5)
        {
            StartCoroutine(PlusMoney());
            AddMoney(timeMoney);
            timer = 0;
        }
    }

    IEnumerator PlusMoney()
    {
        plusMoneyText.text = string.Format("+{0}", timeMoney);
        yield return new WaitForSeconds(0.5f);
        plusMoneyText.text = string.Format(" ");
        yield break;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Player player;

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

    [Header("스토어")]
    [SerializeField]
    private GameObject buyPopupImage;

    [Header("내 정보")]
    [SerializeField]
    private GameObject instPanel;
    [SerializeField]
    private GameObject micPanel;

    private Image mainBtnimage, statusBtnimage, storeBtnimage, settingBtnimage;
    private bool isActive;

    private List<GameObject> btnImages = new List<GameObject>();
    private List<Image> btnObjs = new List<Image>();

    private int oneClickMoney;
    private int moneyPerSec;
    public int playerMoney;
    private int popular;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        player = FindObjectOfType<Player>();
        playerMoney = PlayerPrefs.GetInt("Money", 0);
        oneClickMoney = PlayerPrefs.GetInt("onc2",1);
        popular = PlayerPrefs.GetInt("p1", 0);
        UpdateUI();
        SetBtnList();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AddMoney(10000);
        }
    }

    public void UpdateUI()
    {
        oneClickMoney = PlayerPrefs.GetInt("onc2", 1);
        moneyPerSec = PlayerPrefs.GetInt("test234", 0);

        moneyText.text = string.Format("₩:{0}원", playerMoney);
        statusText.text = string.Format("이름: 이미녕\n클릭당 획든 돈: {0}원\n초당 획든 돈:{1}원\n자본금: {2}원\n악기:는 거꾸로해도 기악\n현재상태: 거지음악가\n인기도:{3}", oneClickMoney, moneyPerSec, playerMoney, popular);
        oneClickText.text = string.Format("Click-{0}", oneClickMoney);
    }

    public void AddMoney(int addMoney)
    {
        playerMoney += addMoney;
        PlayerPrefs.SetInt("Money", playerMoney);
        UpdateUI();
    }

    public void OnClickMain()
    {
        BtnActive(mainImage);
        player.PlayerActive();
    }

    public void OnClickStatus()
    {
        BtnActive(statusImage);
        player.PlayerInactive();
    }

    public void OnClickStore()
    {
        BtnActive(storeImage);
        player.PlayerInactive();
    }

    public void OnClickSetting()
    {
        BtnActive(settingImage);
        player.PlayerInactive();
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
        Debug.Log(oneClickMoney);
        Debug.Log(playerMoney);


        if (mainImage.activeSelf)
        {
            AddMoney(oneClickMoney);
        }

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
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private Text moneyText;
    
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

    void Update()
    {
        
    }

    public void UpdateUI()
    {
        moneyText.text = string.Format("{0}¿ø", money);
    }

    public void AddMoney(int addScore)
    {
        money += addScore;
        PlayerPrefs.SetInt("Money", money);
        UpdateUI();
    }
}

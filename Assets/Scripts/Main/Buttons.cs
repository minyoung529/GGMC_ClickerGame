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
    private float percent;
    private int money;
    private int number;
    private string btnName;

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

    public MainButtonData mainButtonData;
    #endregion

    private void Start()
    {
        ca = FindObjectOfType<ClickArea>();
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
        //this.percent = mainButtonData.percent;
        this.money = mainButtonData.money;
        this.number = mainButtonData.number;
        this.btnName = mainButtonData.name;

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
        if (GameManager.Instance.money - mainButtonData.money < 0) return;

        GameManager.Instance.Min(money);
        mainButtonData.money += 10;
        mainButtonData.level += 1;
        mainButtonData.number += 1;
        ca.money += 1;
        Setup(this.mainButtonData);
    }
}

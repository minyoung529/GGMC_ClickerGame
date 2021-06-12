using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField]
    private Image image;
    [SerializeField]
    private Image buttonImage;
    private Sprite btnSprite;
    private int level;
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

    public MainButtonData mainButtonData;

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

        if(GameManager.Instance.money < money)
        {
            buttonImage.color = new Color(0f, 0f, 0f, 0.5f);
            image.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
    }
}

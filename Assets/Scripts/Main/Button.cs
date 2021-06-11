using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField]
    private Image image;
    private Sprite btnSprite;
    private int level;
    private float percent;
    private int click_Money;
    private int click_Number;
    private string btnName;

    [SerializeField]
    private Text levelText;
    [SerializeField]
    private Text percentText;
    [SerializeField]
    private Text clickText;
    [SerializeField]
    private Text nameText;

    public MainButtonData mainButtonData;

    public void Setup(MainButtonData mainButtonData)
    {
        this.mainButtonData = mainButtonData;
        image.sprite = mainButtonData.sprite;
        this.level = mainButtonData.level;
        //this.percent = mainButtonData.percent;
        this.click_Money = mainButtonData.money;
        this.click_Number = mainButtonData.number;
        this.btnName = mainButtonData.name;

        levelText.text = string.Format("Level {0}", level);
        //percentText.text = string.Format("{0}%", percent);
        clickText.text = string.Format("click+{0} {0}원", click_Number, click_Money);
        nameText.text = string.Format("{0}", btnName);
        //이미지 바뀌느 거 추가하기
    }
}

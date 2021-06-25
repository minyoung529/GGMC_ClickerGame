using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstButtons : MonoBehaviour
{
    private string btnName;
    private int money;
    private int popular;
    private int moneyPS;
    private Sprite instSprite;
    private string info;

    public Instrument inst;

    [SerializeField]
    GameObject BuyPopup;
    [SerializeField]
    Text nameText, infoText, detailText, moneyText;
    [SerializeField]
    Image instImage;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Setup(Instrument instData)
    {
        this.inst = instData;
        this.btnName = instData.instName;
        this.money = instData.money;
        this.popular = instData.popular;
        this.moneyPS = instData.moneyPerSec;
        this.instSprite = instData.instSprite;
        this.info = instData.info;
    }

    public void OnClickBuy()
    {
        Debug.Log(btnName);
        BuyPopup.SetActive(true);

        nameText.text = string.Format("{0}", btnName);
        infoText.text = string.Format("{0}", info);
        detailText.text = string.Format("5ÃÊ´ç È¹µæ µ·: {0}¿ø\nÀÎ±âµµ +{1}¿ø", moneyPS, popular);
        moneyText.text = string.Format("{0}¿ø", money);
        instImage.sprite = instSprite;
    }

    public void ReturnName()
    {

    }    
}

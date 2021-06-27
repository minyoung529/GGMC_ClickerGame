using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status_Inst_Btn : MonoBehaviour
{
    [SerializeField]
    Image btnImage;

    private string btnName;
    private int money;
    private int popular;
    private int moneyPS;
    private Sprite instSprite;
    private string info;
    public Instrument inst;

    void Start()
    {
        ChangeSprite();
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

        ChangeSprite();
    }

    private void ChangeSprite()
    {
        if(btnName == "ÅÆ¹ö¸°" && PlayerPrefs.GetString("inst11") == "isSold")
        {
            btnImage.sprite = instSprite;
        }

        else if (btnName == "±âÅ¸" && PlayerPrefs.GetString("inst22") == "isSold")
        {
            btnImage.sprite = instSprite;
        }
    }
}

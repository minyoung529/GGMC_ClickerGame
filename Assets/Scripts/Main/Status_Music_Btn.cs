using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status_Music_Btn : MonoBehaviour
{
    [SerializeField]
    Image btnImage, playerMusicImage;
    [SerializeField]
    Sprite musicEnabled;
    [SerializeField]
    GameObject choosePopup;
    [SerializeField]
    Text chooseText;

    private string btnName;
    private int money;
    private int popular;
    private int moneyPS;
    private Sprite musicSprite;
    private string info;
    public Music music;

    public void Setup(Music music)
    {
        this.music = music;
        this.btnName = music.musicName;
        this.money = music.money;
        this.popular = music.popular;
        this.moneyPS = music.moneyPerSec;
        this.musicSprite = music.musicSprite;
        this.info = music.info;

        ChangeSprite();
    }

    public void ChangeSprite()
    {
        if (btnName == "��" && PlayerPrefs.GetString("music1") == "isSold")
        {
            btnImage.sprite = musicSprite;
        }

        else if (btnName == "Nighty Night" && PlayerPrefs.GetString("music2") == "isSold")
        {
            btnImage.sprite = musicSprite;
        }

        else if (btnName == "SUMMER STORM!" && PlayerPrefs.GetString("music3") == "isSold")
        {
            btnImage.sprite = musicSprite;
        }

        else if (btnName == "��¼��" && PlayerPrefs.GetString("music4") == "isSold")
        {
            btnImage.sprite = musicSprite;
        }

        else if (btnName == "��¼��" && PlayerPrefs.GetString("music5") == "isSold")
        {
            btnImage.sprite = musicSprite;
        }

        //else if (btnName == "�巳" && PlayerPrefs.GetString("music6") == "isSold")
        //{
        //    btnImage.sprite = musicSprite;
        //}
    }
}

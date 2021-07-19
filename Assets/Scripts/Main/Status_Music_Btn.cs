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
        if (btnName == null) return;

        if (btnName == "º½" && PlayerPrefs.GetString("music1") == "isSold")
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

        else if (btnName == "¾îÂ¼±¸" && PlayerPrefs.GetString("music4") == "isSold")
        {
            btnImage.sprite = musicSprite;
        }

        else if (btnName == "ÀúÂ¼±¸" && PlayerPrefs.GetString("music5") == "isSold")
        {
            btnImage.sprite = musicSprite;
        }
    }

    public void SelectChoose()
    {
        choosePopup.SetActive(false);

        PlayerPrefs.SetString("pmusic", btnName);
        PlayerPrefs.SetInt("musicPS", moneyPS);
        GameManager.Instance.UpdateUI();
        SoundManager.instance.PlayMusic(PlayerPrefs.GetString("pmusic", "A Little Ghost"));
    }

    public void OnClickMusic()
    {
        if (btnImage.sprite == musicEnabled) return;

        choosePopup.SetActive(true);
        Text nameText = choosePopup.transform.GetChild(0).GetComponentInChildren<Text>();
        Text informText = choosePopup.transform.GetChild(1).GetComponentInChildren<Text>();
        Text secText = choosePopup.transform.GetChild(2).GetComponentInChildren<Text>();

        nameText.text = string.Format("{0}", btnName);
        informText.text = string.Format("{0}", info);
        secText.text = string.Format("5Sec - {0}", moneyPS);
    }

    public void OnClickPutMusic()
    {
        Text nameText = choosePopup.transform.GetChild(0).GetComponentInChildren<Text>();

        if (nameText.text == btnName)
        {
            SelectChoose();
        }
    }
}

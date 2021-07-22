using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMusicCD : MonoBehaviour
{
    private string playerMusic;
    [SerializeField]
    private Image image;
    [SerializeField]
    private MusicSO musicSO;

    void Start()
    {
        playerMusic = PlayerPrefs.GetString("pmusic", "A Little Ghost");
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        playerMusic = PlayerPrefs.GetString("pmusic", "A Little Ghost");

        for (int i = 0; i<musicSO.musics.Length; i++)
        {
            if(playerMusic == musicSO.musics[i].musicName)
            {
                image.sprite = musicSO.musics[i].musicSprite;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPlayerMIC : MonoBehaviour
{
    [SerializeField]
    Sprite kara, dyn, gg157, con, year, mi;

    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        switch (PlayerPrefs.GetString("pm", "노래방 마이크"))
        {
            case "노래방 마이크":
                image.sprite = kara;
                break;

            case "다이나믹 마이크":
                image.sprite = dyn;
                break;

            case "GG157":
                image.sprite = gg157;
                break;

            case "콘덴서 마이크":
                image.sprite = con;
                break;

            case "인이어 마이크":
                image.sprite = year;
                break;

            case "마이스트로":
                image.sprite = mi;
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPlayerMIC : MonoBehaviour
{
    [SerializeField]
    Sprite gar, pororo, kara, used, well, gg157, broad, idol, shiba, studio, angel, voice;

    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        Debug.Log(PlayerPrefs.GetString("pm", "쓰레기통에서 주운 마이크"));
        switch (PlayerPrefs.GetString("pm", "쓰레기통에서 주운 마이크"))
        {
            case "쓰레기통에서 주운 마이크":
                image.sprite = gar;
                break;

            case "뽀로로 마이크":
                image.sprite = pororo;
                break;

            case "노래방에서 가져온 마이크":
                image.sprite = kara;
                break;

            case "매우 중고 마이크":
                image.sprite = used;
                break;

            case "좀 좋아 보이는 마이크":
                image.sprite = well;
                break;

            case "GG157":
                image.sprite = gg157;
                break;

            case "방송용 마이크":
                image.sprite = broad;
                break;

            case "아이돌이 쓸 법한 마이크":
                image.sprite = idol;
                break;

            case "Shiba's VoicE":
                image.sprite = shiba;
                break;

            case "스튜디오 마이크":
                image.sprite = studio;
                break;

            case "The Angel's Ring":
                image.sprite = angel;
                break;

            case "목소리":
                image.sprite = voice;
                break;
        }
    }
}

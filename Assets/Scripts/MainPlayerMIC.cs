using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerMIC : MonoBehaviour
{
    [SerializeField]
    Sprite gar, pororo, kara, used, well, gg157, broad, idol, shiba, studio, angel, voice;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        switch (PlayerPrefs.GetString("pm", "쓰레기통에서 주운 마이크"))
        {
            case "쓰레기통에서 주운 마이크":
                spriteRenderer.sprite = gar;
                break;

            case "뽀로로 마이크":
                spriteRenderer.sprite = pororo;
                break;

            case "노래방에서 가져온 마이크":
                spriteRenderer.sprite = kara;
                break;

            case "매우 중고 마이크":
                spriteRenderer.sprite = used;
                break;

            case "좀 좋아 보이는 마이크":
                spriteRenderer.sprite = well;
                break;

            case "GG157":
                spriteRenderer.sprite = gg157;
                break;

            case "방송용 마이크":
                spriteRenderer.sprite = broad;
                break;

            case "아이돌이 쓸 법한 마이크":
                spriteRenderer.sprite = idol;
                break;

            case "Shiba's VoicE":
                spriteRenderer.sprite = shiba;
                break;

            case "스튜디오 마이크":
                spriteRenderer.sprite = studio;
                break;

            case "The Angel's Ring":
                spriteRenderer.sprite = angel;
                break;

            case "목소리":
                spriteRenderer.sprite = voice;
                break;
        }
    }
}
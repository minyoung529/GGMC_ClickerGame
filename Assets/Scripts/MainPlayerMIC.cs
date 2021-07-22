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
                transform.localPosition = new Vector2(-0.6f, -0.7f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;

            case "뽀로로 마이크":
                spriteRenderer.sprite = pororo;
                transform.localPosition = new Vector2(0.1f, -0.2f);
                transform.localScale = new Vector2(0.6f, 0.6f);
                transform.localScale = new Vector2(0.6f, 0.6f);
                break;

            case "노래방에서 가져온 마이크":
                spriteRenderer.sprite = kara;
                transform.localPosition = new Vector2(0.1f, -0.2f);
                transform.localScale = new Vector2(0.6f, 0.6f);
                break;

            case "매우 중고 마이크":
                spriteRenderer.sprite = used;
                transform.localPosition = new Vector2(-0.7f, -0.7f);
                transform.localScale = new Vector2(0.8f, 0.8f);
                break;

            case "좀 좋아 보이는 마이크":
                spriteRenderer.sprite = well;
                transform.localPosition = new Vector2(0.2f, -1f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;

            case "GG157":
                spriteRenderer.sprite = gg157;
                transform.localPosition = Vector2.zero;
                transform.localScale = new Vector2(0.6f, 0.6f);
                break;

            case "방송용 마이크":
                spriteRenderer.sprite = broad;
                transform.localPosition = new Vector2(-1f, -0.5f);
                transform.localScale = new Vector2(0.85f, 0.85f);
                break;

            case "아이돌이 쓸 법한 마이크":
                spriteRenderer.sprite = idol;
                transform.localPosition = new Vector2(-0.9f, 0.62f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;

            case "Shiba's VoicE":
                spriteRenderer.sprite = shiba;
                transform.localPosition = new Vector2(0f, -0.3f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;

            case "스튜디오 마이크":
                spriteRenderer.sprite = studio;
                transform.localPosition = new Vector2(-0.67f, -0.4f);
                transform.localScale = new Vector2(0.9f, 0.9f);
                break;

            case "The Angel's Ring":
                spriteRenderer.sprite = angel;
                transform.localPosition = new Vector2(0f, -0.3f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;

            case "목소리":
                spriteRenderer.sprite = voice;
                transform.localPosition = new Vector2(1.4f, 0.7f);
                transform.localScale = new Vector2(0.7f, 0.7f);
                break;
        }
    }
}
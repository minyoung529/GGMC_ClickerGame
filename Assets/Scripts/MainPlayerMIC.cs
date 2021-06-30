using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerMIC : MonoBehaviour
{
    [SerializeField]
    Sprite kara, dyn, gg157, con, year, mi;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeSprite();
    }

    public void ChangeSprite()
    {
        switch (PlayerPrefs.GetString("pm", "노래방 마이크"))
        {
            case "노래방 마이크":
                spriteRenderer.sprite = kara;
                break;

            case "다이나믹 마이크":
                spriteRenderer.sprite = dyn;
                break;

            case "GG157":
                spriteRenderer.sprite = gg157;
                break;

            case "콘덴서 마이크":
                spriteRenderer.sprite = con;
                break;

            case "인이어 마이크":
                spriteRenderer.sprite = year;
                break;

            case "마이스트로":
                spriteRenderer.sprite = mi;
                break;
        }
    }
}

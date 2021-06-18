using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logo : MonoBehaviour
{
    private float time = 0;
    private float blinkTime = 0.1f;
    private float xTime = 0;
    private float waitTime = 0.2f;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (time < 7f) // 버프 지속시간 -3초
        {
            spriteRenderer.color = new Color(1, 1, 1, 1); // 처음엔 켜져있고
        }

        else // 약 3초
        {
            if (xTime < blinkTime) // 깜빡
            {
                spriteRenderer.color = new Color(1, 1, 1, 1 - xTime * 10); //꺼졌다가
            }
            else if (xTime < waitTime + blinkTime)
            {

            }
            else
            {
                spriteRenderer.color = new Color(1, 1, 1, (xTime - (waitTime + blinkTime)) * 10);
                //켜졌다가
                if (xTime > waitTime + blinkTime * 2)
                {
                    xTime = 0;
                    waitTime *= 0.8f; //깜빡이는 시간 줄어들기
                    if (waitTime < 0.02f)
                    {
                        time = 0;
                        waitTime = 0.2f;
                        this.gameObject.SetActive(false);
                    }
                }
            }
            xTime += Time.deltaTime;
        }
        time += Time.deltaTime;
    }
}

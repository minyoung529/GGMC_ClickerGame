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
        if (time < 7f) // ���� ���ӽð� -3��
        {
            spriteRenderer.color = new Color(1, 1, 1, 1); // ó���� �����ְ�
        }

        else // �� 3��
        {
            if (xTime < blinkTime) // ����
            {
                spriteRenderer.color = new Color(1, 1, 1, 1 - xTime * 10); //�����ٰ�
            }
            else if (xTime < waitTime + blinkTime)
            {

            }
            else
            {
                spriteRenderer.color = new Color(1, 1, 1, (xTime - (waitTime + blinkTime)) * 10);
                //�����ٰ�
                if (xTime > waitTime + blinkTime * 2)
                {
                    xTime = 0;
                    waitTime *= 0.8f; //�����̴� �ð� �پ���
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

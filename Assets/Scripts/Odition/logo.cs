using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logo : MonoBehaviour
{
    float time = 0;
    float blinktime = 0.1f;
    float xtime = 0;
    float waittime = 0.2f;



    // Update is called once per frame
    void Update()
    {
        if (time < 7f) // ���� ���ӽð� -3��
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1); // ó���� �����ְ�
        }
        else // �� 3��
        {
            if (xtime < blinktime) // ����
            {
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1 - xtime * 10); //�����ٰ�
            }
            else if (xtime < waittime + blinktime)
            {

            }
            else
            {
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, (xtime - (waittime + blinktime)) * 10);
                //�����ٰ�
                if (xtime > waittime + blinktime * 2)
                {
                    xtime = 0;
                    waittime *= 0.8f; //�����̴� �ð� �پ���
                    if (waittime < 0.02f)
                    {
                        time = 0;
                        waittime = 0.2f;
                        this.gameObject.SetActive(false);
                    }
                }
            }
            xtime += Time.deltaTime;
        }
        time += Time.deltaTime;
    }

    //�뷫 7�� ����
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipText : MonoBehaviour
{
    Text tipText;

    void Start()
    {
        tipText = GetComponent<Text>();
        StartCoroutine(Tip());
    }

    private IEnumerator Tip()
    {
        int rand;
        while(true)
        {
            rand = Random.Range(0, 4);
            RandomText(rand);
            yield return new WaitForSeconds(2.5f);
        }
    }

    private void RandomText(int rand)
    {
        switch(rand)
        {
            case 1:
                tipText.text = string.Format("Tip: ������� ���� ���� �α⵵�� �÷����� �� ���ƿ�.");
                break;

            case 2:
                tipText.text = string.Format("Tip: �������� �پ��� �뷡�� ���� �� �־��.");
                break;

            case 3:
                tipText.text = string.Format("Tip: �������� ������ ��� �α⵵�� �ø� �� �־��.");
                break;

            case 4:
                tipText.text = string.Format("Tip: �������� �پ��� �뷡�� ���� �� �־��.");
                break;

            default:
                tipText.text = string.Format("Tip: ���ǿ� �ʿ��� ��� �ɷ��� �յ��ϰ� �÷����ؿ�.");
                break;

        }
    }
}

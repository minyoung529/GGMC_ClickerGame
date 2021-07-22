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
                tipText.text = string.Format("Tip: 오디션을 보기 전에 인기도를 올려놓는 게 좋아요.");
                break;

            case 2:
                tipText.text = string.Format("Tip: 상점에서 다양한 노래를 들을 수 있어요.");
                break;

            case 3:
                tipText.text = string.Format("Tip: 상점에서 물건을 사면 인기도를 올릴 수 있어요.");
                break;

            case 4:
                tipText.text = string.Format("Tip: 상점에서 다양한 노래를 들을 수 있어요.");
                break;

            default:
                tipText.text = string.Format("Tip: 음악에 필요한 모든 능력을 균등하게 올려야해요.");
                break;

        }
    }
}

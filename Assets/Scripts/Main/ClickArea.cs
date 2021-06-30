using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickArea : MonoBehaviour
{
    private int money;

    private void OnMouseDown()
    {
        money = PlayerPrefs.GetInt("test1");

        GameManager.Instance.AddMoney(money);

        GameManager.Instance.UpdateUI();
    }
}

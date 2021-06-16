using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickArea : MonoBehaviour
{
    private int money;

    private void Start()
    {
        money = PlayerPrefs.GetInt("test1");
    }

    private void OnMouseDown()
    {
        money = PlayerPrefs.GetInt("test1");

        if (!GameManager.Instance.statusImage.activeSelf)
        GameManager.Instance.AddMoney(money);

        GameManager.Instance.UpdateUI();
    }
}

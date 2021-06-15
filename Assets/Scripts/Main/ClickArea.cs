using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickArea : MonoBehaviour
{
    public int money = 1;

    private void OnMouseDown()
    {
        if(!GameManager.Instance.statusImage.activeSelf)
        GameManager.Instance.AddMoney(money);
        GameManager.Instance.AddMoney(1000);

    }
}

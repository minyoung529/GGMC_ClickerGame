using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickArea : MonoBehaviour
{
    private int money = 1;

    private void OnMouseDown()
    {
        if(!GameManager.Instance.statusImage.activeSelf)
        GameManager.Instance.AddMoney(money);
    }
}

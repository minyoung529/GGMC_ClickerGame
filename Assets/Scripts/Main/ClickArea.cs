using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickArea : MonoBehaviour
{
    private int money = 1;

    private void OnMouseDown()
    {
        GameManager.Instance.AddMoney(money);
    }
}

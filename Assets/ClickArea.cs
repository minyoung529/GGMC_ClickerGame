using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickArea : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameManager.Instance.ClickArea();
    }
}

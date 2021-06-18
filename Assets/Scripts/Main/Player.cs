using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void PlayerActive()
    {
        gameObject.SetActive(true);
    }

    public void PlayerInactive()
    {
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void PlayerActive()
    {
        gameObject.SetActive(true);
    }

    public void PlayerInactive()
    {
        gameObject.SetActive(false);
    }
}

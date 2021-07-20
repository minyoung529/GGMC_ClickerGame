using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.y < -3f)
        {
            Destroy(gameObject);
        }
    }
}

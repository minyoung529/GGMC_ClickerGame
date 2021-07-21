using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    private int timeMoney;
    private SpriteRenderer spriteRenderer;
    [SerializeField] Sprite money, jewelry;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        timeMoney = PlayerPrefs.GetInt("micPS", 0) + PlayerPrefs.GetInt("instPS", 1) + PlayerPrefs.GetInt("musicPS", 1);

        if (timeMoney > 50 && timeMoney < 500)
        {
            int rand = Random.Range(0, 5);

            if (rand == 1)
                spriteRenderer.sprite = money;
        }

        else if(timeMoney > 800)
        {
            int rand = Random.Range(0, 3);

            if (rand == 1)
                spriteRenderer.sprite = money;
            else if (rand == 2)
                spriteRenderer.sprite = jewelry;
        }
    }

    private void Update()
    {
        if (transform.position.y < -3f)
        {
            Destroy(gameObject);
        }
    }
}

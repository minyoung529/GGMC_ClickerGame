using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AuditionButton : MonoBehaviour
{
    private Animator fadein;
    private Animator post;
    private Loadbtn btn;
    private int percent;
    private GameManager gamemanager;
    private Animator success;
    private int rand;
    private int popular;
    private Image img;

    private int successCnt;

    public bool click = false;

    void Start()
    {
        fadein = GameObject.Find("fadee").GetComponent<Animator>();
        btn = FindObjectOfType<Loadbtn>();
        post = GameObject.Find("post").GetComponent<Animator>();
        gamemanager = FindObjectOfType<GameManager>();
        success = GameObject.Find("success").GetComponent<Animator>();
        rand = Random.Range(1, 100);
        popular = PlayerPrefs.GetInt("p1", 0);
        successCnt = PlayerPrefs.GetInt("audition", 1);
        img = GetComponent<Image>();
    }

    public void ButtonClick()
    {
        fadein.Play("fade2");
        btn.postclick = true;
        fadein.Play("fade1");
        post.Play("post3");
    }
    public void Percent()
    {
        if (5 + (popular / 6) >= rand)
        {
            success.Play("suc2");
            successCnt++;
            PlayerPrefs.SetInt("audition", successCnt);
        }

        else
        {
            success.Play("suc3");
        }

        img.raycastTarget = false;
        StartCoroutine(Wait());
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(4f);
        click = true;
    }
}

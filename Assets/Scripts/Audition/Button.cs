using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
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

    public bool click = false;

    // Start is called before the first frame update
    void Start()
    {
        fadein = GameObject.Find("fadee").GetComponent<Animator>();
        btn = FindObjectOfType<Loadbtn>();
        post = GameObject.Find("post").GetComponent<Animator>();
        gamemanager = FindObjectOfType<GameManager>();
        success = GameObject.Find("success").GetComponent<Animator>();
        rand = Random.Range(1, 100);
        popular = PlayerPrefs.GetInt("p1", 0);
        img = GetComponent<Image>();
        if (img == null)
        {
            Debug.Log("½Ç");
        }
        else
        {
            Debug.Log("¼º");
        }
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
        }
        else
        {
            success.Play("suc3");
        }
        img.raycastTarget = false;
        StartCoroutine(wait());
        click = true;
    }
    private IEnumerator wait()
    {
        yield return new WaitForSeconds(5f);
    }
}

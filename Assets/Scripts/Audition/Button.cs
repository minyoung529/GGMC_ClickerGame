using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private Animator fadein;
    private Animator post;
    private Loadbtn btn;
    // Start is called before the first frame update
    void Start()
    {
        fadein = GameObject.Find("fadee").GetComponent<Animator>();
        btn = FindObjectOfType<Loadbtn>();
        post = GameObject.Find("post").GetComponent<Animator>();
    }

    public void ButtonClick()
    {
        fadein.Play("fade2");
        btn.postclick = true;
        sec();
        fadein.Play("fade1");
        post.Play("post3");
        Destroy(gameObject);
    }
    private IEnumerator sec()
    {
        yield return new WaitForSeconds(2.5f);
    }
}

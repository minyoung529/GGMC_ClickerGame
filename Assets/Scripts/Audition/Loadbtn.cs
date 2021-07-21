using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadbtn : MonoBehaviour
{
    public bool postclick = false;

    private Animator left;
    private Animator right;
    private Animator middle;
    // Start is called before the first frame update
    void Start()
    {
        left = GameObject.Find("left").GetComponent<Animator>();
        right = GameObject.Find("right").GetComponent<Animator>();
        middle = GameObject.Find("middle").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(postclick == true)
        {
            left.Play("normal");
            right.Play("normal3");
            middle.Play("normal2");
        }
        postclick = false;
    }
}

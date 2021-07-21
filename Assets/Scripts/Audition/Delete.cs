using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Delete : MonoBehaviour
{
    private AuditionButton btn;
    void Start()
    {
        btn = FindObjectOfType<AuditionButton>();
    }

    void Update()
    {
        if(btn.click == true)
        {
            if(Input.GetMouseButton(0) == true)
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
}

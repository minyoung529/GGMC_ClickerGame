using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class delete : MonoBehaviour
{
    private Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = FindObjectOfType<Button>();
    }

    // Update is called once per frame
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

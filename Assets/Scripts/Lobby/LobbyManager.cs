using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LobbyManager : MonoBehaviour
{
    [SerializeField]
    private Sprite OnClickSprite;
    [SerializeField]
    private GameObject info, quit;

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            quit.SetActive(true);
        }
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("Loading");
    }

    public void OnClickInfo(bool isTrue)
    {
        info.SetActive(isTrue);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void NotQuit()
    {
        quit.SetActive(false);
    }
}

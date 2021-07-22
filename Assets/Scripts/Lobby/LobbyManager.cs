using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LobbyManager : MonoBehaviour
{
    [SerializeField]
    private Sprite OnClickSprite;
    [SerializeField]
    private GameObject info;

    public void OnClickStart()
    {
        SceneManager.LoadScene("Loading");
    }

    public void OnClickInfo(bool isTrue)
    {
        info.SetActive(isTrue);
    }
}

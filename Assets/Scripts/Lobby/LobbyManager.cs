using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LobbyManager : MonoBehaviour
{
    [SerializeField]
    private Sprite OnClickSprite;

    public void OnClickStart()
    {
        SceneManager.LoadScene("Main");
    }
}

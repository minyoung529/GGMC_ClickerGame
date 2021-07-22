using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingController : MonoBehaviour
{
    private float time = 0f;
    [SerializeField]
    GameObject player, bar, canvas;

    void Start()
    {
        StartCoroutine(LoadingSceneProcess());
    }

    private void Update()
    {
        time += Time.deltaTime;
    }

    IEnumerator LoadingSceneProcess()
    {
        AsyncOperation op = SceneManager.LoadSceneAsync("Main");
        op.allowSceneActivation = false;

        while (!op.isDone)
        {

            if (time > 5)
            {
                op.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}

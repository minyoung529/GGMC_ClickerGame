using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    [SerializeField]
    GameObject storeContents;
    [SerializeField]
    Button instBtn, micBtn, musicBtn;

    public void inst()
    {
        SetButtonColor();
        storeContents.transform.GetChild(0).gameObject.SetActive(true);
        storeContents.transform.GetChild(1).gameObject.SetActive(false);
        storeContents.transform.GetChild(2).gameObject.SetActive(false);
        ButtonColor(instBtn);
    }

    public void mic()
    {
        SetButtonColor();
        storeContents.transform.GetChild(0).gameObject.SetActive(false);
        storeContents.transform.GetChild(1).gameObject.SetActive(true);
        storeContents.transform.GetChild(2).gameObject.SetActive(false);
        ButtonColor(micBtn);
    }

    public void music()
    {
        SetButtonColor();
        storeContents.transform.GetChild(0).gameObject.SetActive(false);
        storeContents.transform.GetChild(1).gameObject.SetActive(false);
        storeContents.transform.GetChild(2).gameObject.SetActive(true);
        ButtonColor(musicBtn);
    }

    private void SetButtonColor()
    {
        instBtn.image.color = new Color32(229, 229, 229, 255);
        micBtn.image.color = new Color32(229, 229, 229, 255);
        musicBtn.image.color = new Color32(229, 229, 229, 255);
    }

    private void ButtonColor(Button button)
    {
        button.image.color = new Color32(255, 207, 95, 255);
    }
}

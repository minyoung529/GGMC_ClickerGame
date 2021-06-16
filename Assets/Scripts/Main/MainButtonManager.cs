using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainButtonManager : MonoBehaviour
{
    [SerializeField]
    MainButtonDataSO MainButtonDataSO;
    [SerializeField]
    GameObject mainButtonPosition;
    private List<MainButtonData> mainButons;
    private List<GameObject> buttonsChild;
    private void Start()
    {
        SetUp_MainBtns();
    }

    //setup main button
    public void SetUp_MainBtns()
    {
        mainButons = new List<MainButtonData>();

        for (int i = 0; i < MainButtonDataSO.mainBtnDatas.Length; i++)
        {
            MainButtonData mainbtns = MainButtonDataSO.mainBtnDatas[i];
            mainButons.Add(mainbtns);
        }
        Update_MainBtn();
    }

    public void Update_MainBtn()
    {
        for (int i = 0; i < mainButons.Count; i++)
        {
            var btnObj = mainButtonPosition.transform.GetChild(i);
            var button = btnObj.GetComponent<Buttons>();
            button.Setup(mainButons[i]);
        }
    }
}

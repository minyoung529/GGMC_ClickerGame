using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonManager : MonoBehaviour
{
    [SerializeField]
    MainButtonDataSO MainButtonDataSO;
    [SerializeField]
    GameObject mainButtonPrefab;
    [SerializeField]
    GameObject mainButtonPosition;
    private List<MainButtonData> mainButons;

    private void Start()
    {
        SetUp_MainBtns();
    }

    private void SetUp_MainBtns()
    {
        mainButons = new List<MainButtonData>();

        for(int i = 0; i< MainButtonDataSO.mainBtnDatas.Length; i++)
        {
            MainButtonData mainbtns = MainButtonDataSO.mainBtnDatas[i];
            mainButons.Add(mainbtns);
        }
        Instantiate_MainBtn();
    }

    public void Instantiate_MainBtn()
    {
        for (int i = 0; i < mainButons.Count; i++)
        {
            var btnObj = Instantiate(mainButtonPrefab, mainButtonPosition.transform);
            var Button = btnObj.GetComponent<Button>();
            Button.Setup(mainButons[i]);
        }
    }

}

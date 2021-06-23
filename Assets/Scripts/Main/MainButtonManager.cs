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
    private List<MainButtonData> mainButtons;

    [SerializeField]
    InstrumentSO storeButtonDataSO;
    [SerializeField]
    GameObject storeButtonPosition;
    private List<Instrument> storeButtons;
    private void Start()
    {
        SetUp_MainBtns();
        SetUp_StoreBtns();
    }

    public void SetUp_MainBtns()
    {
        mainButtons = new List<MainButtonData>();

        for (int i = 0; i < MainButtonDataSO.mainBtnDatas.Length; i++)
        {
            MainButtonData mainbtns = MainButtonDataSO.mainBtnDatas[i];
            mainButtons.Add(mainbtns);
        }

        Update_MainBtn();
    }

    public void Update_MainBtn()
    {
        for (int i = 0; i < mainButtons.Count; i++)
        {
            var btnObj = mainButtonPosition.transform.GetChild(i);
            var button = btnObj.GetComponent<Buttons>();
            button.Setup(mainButtons[i]);
        }
    }

    public void SetUp_StoreBtns()
    {
        storeButtons = new List<Instrument>();

        for (int i = 0; i < storeButtonDataSO.instruments.Length; i++)
        {
            Instrument storeInsts = storeButtonDataSO.instruments[i];
            storeButtons.Add(storeInsts);
        }

        Update_StoreBtn();
    }

    public void Update_StoreBtn()
    {
        for (int i = 0; i < storeButtons.Count; i++)
        {
            var btnObj = storeButtonPosition.transform.GetChild(i);
            var button = btnObj.GetComponent<InstButtons>();
            button.Setup(storeButtons[i]);
        }
    }
}

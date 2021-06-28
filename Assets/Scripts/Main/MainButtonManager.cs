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

    [SerializeField]
    GameObject statusInstButtonPos;
    private List<Instrument> statusInstBtn;

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
        statusInstBtn = new List<Instrument>();

        for (int i = 0; i < storeButtonDataSO.instruments.Length; i++)
        {
            Instrument statusInsts = storeButtonDataSO.instruments[i];
            if (i == storeButtonDataSO.instruments.Length - 1) continue;
            Instrument storeInsts = storeButtonDataSO.instruments[i + 1];
            storeButtons.Add(storeInsts);
            statusInstBtn.Add(statusInsts);
        }

        Update_StoreBtn();
        Update_Status_Inst_Btn();
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

    public void Update_Status_Inst_Btn()
    {
        for (int i = 0; i < storeButtons.Count; i++)
        {
            var btnObj = statusInstButtonPos.transform.GetChild(i);
            var button = btnObj.GetComponent<Status_Inst_Btn>();
            button.Setup(statusInstBtn[i]);
        }
    }

    public void ChangeInstSprite()
    {
        for (int i = 0; i < storeButtons.Count; i++)
        {
            var statusInstBtn = statusInstButtonPos.transform.GetChild(i);
            var storeInstBtn = storeButtonPosition.transform.GetChild(i);

            statusInstBtn.GetComponent<Status_Inst_Btn>().ChangeSprite();
            storeInstBtn.GetComponent<InstButtons>().CheckData();
        }
    }
}

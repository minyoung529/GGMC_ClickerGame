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
    private InstrumentSO storeButtonDataSO;
    [SerializeField]
    private MICSO storeMICDataSO;

    [SerializeField]
    GameObject storeButtonPosition, storeMICButtonPosition;

    [SerializeField]
    GameObject statusInstButtonPos, statusMICButtonsPos;

    public List<MIC> statusMICButtons;
    public List<Instrument> statusInstBtn;

    public List<Instrument> storeButtons;
    public List<MIC> micStoreButtons;

    private void Awake()
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
        micStoreButtons = new List<MIC>();
        statusMICButtons = new List<MIC>();

        Debug.Log(storeButtonDataSO.instruments.Length);
        for (int i = 0; i < storeButtonDataSO.instruments.Length; i++)
        {
            Instrument statusInsts = storeButtonDataSO.instruments[i];
            statusInstBtn.Add(statusInsts);

            if (i == storeButtonDataSO.instruments.Length - 1) continue;
            Instrument storeInsts = storeButtonDataSO.instruments[i + 1];

            storeButtons.Add(storeInsts);
        }

        for (int i = 0; i < storeMICDataSO.mics.Length; i++)
        {
            MIC statusMICs = storeMICDataSO.mics[i];
            statusMICButtons.Add(statusMICs);

            if (i == storeMICDataSO.mics.Length - 1) continue;
            MIC storeMICs = storeMICDataSO.mics[i + 1];

            micStoreButtons.Add(storeMICs);
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

        for (int i = 0; i < micStoreButtons.Count; i++)
        {
            var btnObj = storeMICButtonPosition.transform.GetChild(i);
            var button = btnObj.GetComponent<MICButtons>();
            button.Setup(micStoreButtons[i]);
        }
    }

    public void Update_Status_Inst_Btn()
    {
        for (int i = 0; i < statusInstBtn.Count; i++)
        {
            var btnObj = statusInstButtonPos.transform.GetChild(i);
            var button = btnObj.GetComponent<Status_Inst_Btn>();
            button.Setup(statusInstBtn[i]);
        }

        for (int i = 0; i < statusMICButtons.Count; i++)
        {
            var micBtnObj = statusMICButtonsPos.transform.GetChild(i);
            var micButton = micBtnObj.GetComponent<Status_MIC_Btn>();
            micButton.Setup(statusMICButtons[i]);
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

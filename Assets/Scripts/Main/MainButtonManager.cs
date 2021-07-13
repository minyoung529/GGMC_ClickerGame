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
    private InstrumentSO storeInstDataSO;
    [SerializeField]
    private MICSO storeMICDataSO;
    [SerializeField]
    private MusicSO storeMusicDataSO;

    [SerializeField]
    GameObject storeInstPos, storeMICPos, storeMusicPos;

    [SerializeField]
    GameObject statusInstPos, statusMICPos, statusMusicPos;

    public List<MIC> statusMIC;
    public List<Instrument> statusInst;
    public List<Music> statusMusic;

    public List<Instrument> storeInst;
    public List<MIC> storeMIC;
    public List<Music> storeMusic;

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
        storeInst = new List<Instrument>();
        statusInst = new List<Instrument>();
        storeMIC = new List<MIC>();
        statusMIC = new List<MIC>();
        storeMusic = new List<Music>();
        statusMusic = new List<Music>();

        for (int i = 0; i < storeInstDataSO.instruments.Length; i++)
        {
            Instrument statusInsts = storeInstDataSO.instruments[i];
            statusInst.Add(statusInsts);

            if (i == storeInstDataSO.instruments.Length - 1) continue;
            Instrument storeInsts = storeInstDataSO.instruments[i + 1];

            storeInst.Add(storeInsts);
        }

        for (int i = 0; i < storeMICDataSO.mics.Length; i++)
        {
            MIC statusMICs = storeMICDataSO.mics[i];
            statusMIC.Add(statusMICs);

            if (i == storeMICDataSO.mics.Length - 1) continue;
            MIC storeMICs = storeMICDataSO.mics[i + 1];

            storeMIC.Add(storeMICs);
        }

        for (int i = 0; i < storeMusicDataSO.musics.Length; i++)
        {
            Music statusMusics = storeMusicDataSO.musics[i];
            statusMusic.Add(statusMusics);

            if (i == storeMusicDataSO.musics.Length - 1) continue;
            Music storeMusics = storeMusicDataSO.musics[i + 1];

            storeMusic.Add(storeMusics);
        }

        Update_StoreBtn();
        Update_Status_Inst_Btn();
    }

    public void Update_StoreBtn()
    {
        for (int i = 0; i < storeInst.Count; i++)
        {
            var btnObj = storeInstPos.transform.GetChild(i);
            var button = btnObj.GetComponent<InstButtons>();
            button.Setup(storeInst[i]);
        }

        for (int i = 0; i < storeMIC.Count; i++)
        {
            var btnObj = storeMICPos.transform.GetChild(i);
            var button = btnObj.GetComponent<MICButtons>();
            button.Setup(storeMIC[i]);
        }

        for (int i = 0; i < storeMusic.Count; i++)
        {
            var btnObj = storeMusicPos.transform.GetChild(i);
            var button = btnObj.GetComponent<MusicButtons>();
            button.Setup(storeMusic[i]);
        }
    }

    public void Update_Status_Inst_Btn()
    {
        for (int i = 0; i < statusInst.Count; i++)
        {
            var btnObj = statusInstPos.transform.GetChild(i);
            var button = btnObj.GetComponent<Status_Inst_Btn>();
            button.Setup(statusInst[i]);
        }

        for (int i = 0; i < statusMIC.Count; i++)
        {
            var btnObj = statusMICPos.transform.GetChild(i);
            var button = btnObj.GetComponent<Status_MIC_Btn>();
            button.Setup(statusMIC[i]);
        }

        for (int i = 0; i < statusMusic.Count; i++)
        {
            var btnObj = statusMusicPos.transform.GetChild(i);
            var button = btnObj.GetComponent<Status_Music_Btn>();
            button.Setup(statusMusic[i]);
        }
    }

    public void ChangeInstSprite()
    {
        for (int i = 0; i < storeInst.Count; i++)
        {
            var statusInstBtn = statusInstPos.transform.GetChild(i);
            var storeInstBtn = storeInstPos.transform.GetChild(i);

            statusInstBtn.GetComponent<Status_Inst_Btn>().ChangeSprite();
            storeInstBtn.GetComponent<InstButtons>().CheckData();
        }

        for (int i = 0; i < storeMIC.Count; i++)
        {
            var statusMICBtn = statusMICPos.transform.GetChild(i);
            var storeMICBtn = storeMICPos.transform.GetChild(i);

            statusMICBtn.GetComponent<Status_MIC_Btn>().ChangeSprite();
            storeMICBtn.GetComponent<MICButtons>().CheckData();
        }

        for (int i = 0; i < storeMusic.Count; i++)
        {
            var statusMusicBtn = statusMusicPos.transform.GetChild(i);
            var storeMusicBtn = storeMusicPos.transform.GetChild(i);

            statusMusicBtn.GetComponent<Status_Music_Btn>().ChangeSprite();
            storeMusicBtn.GetComponent<MusicButtons>().CheckData();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstButtons : MonoBehaviour
{
    private string btnName;

    public Instrument inst;

    [SerializeField]
    GameObject BuyPopup;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Setup(Instrument instData)
    {
        this.inst = instData;
        this.btnName = instData.instName;
    }

    public void OnClickBuy()
    {
        Debug.Log(btnName);
        BuyPopup.SetActive(true);
    }

    public void ReturnName()
    {

    }    
}

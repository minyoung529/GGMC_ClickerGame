using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    [SerializeField]
    GameObject storeContents;
    void Start()
    {
        
    }

    public void inst()
    {
        storeContents.transform.GetChild(0).gameObject.SetActive(true);
        storeContents.transform.GetChild(1).gameObject.SetActive(false);
        storeContents.transform.GetChild(2).gameObject.SetActive(false);
    }

    public void mic()
    {
        storeContents.transform.GetChild(0).gameObject.SetActive(false);
        storeContents.transform.GetChild(1).gameObject.SetActive(true);
        storeContents.transform.GetChild(2).gameObject.SetActive(false);
    }

    public void music()
    {
        storeContents.transform.GetChild(0).gameObject.SetActive(false);
        storeContents.transform.GetChild(1).gameObject.SetActive(false);
        storeContents.transform.GetChild(2).gameObject.SetActive(true);
    }
}

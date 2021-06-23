using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreImage : MonoBehaviour
{
    [SerializeField]
    GameObject buyPopUp;


    private void OnMouseUp()
    {
        Debug.Log("sdf");

        if (buyPopUp.activeSelf)
        {
            buyPopUp.SetActive(false);
        }
    }
}

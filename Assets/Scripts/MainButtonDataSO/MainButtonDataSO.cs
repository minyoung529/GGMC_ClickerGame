using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MainButtonData
{
    public string name;
    public Sprite sprite;
    public int level;
    public float percent;
    public int money;
    public int number;
}

[CreateAssetMenu(fileName = "MainButtonDataSO", menuName = "Sprictable Object/MainButtonDataSO")]
public class MainButtonDataSO : ScriptableObject
{
    public MainButtonData[] mainBtnDatas;
}


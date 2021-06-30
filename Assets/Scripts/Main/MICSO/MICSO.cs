using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class MIC
{
    public string micName;
    public Sprite micSprite;
    public int money;
    public int moneyPerSec;
    public int popular;
    [TextArea] public string info;
}

[CreateAssetMenu(fileName = "MICSO", menuName = "Sprictable Object/MICSO")]

public class MICSO : ScriptableObject
{
    public MIC[] mics;
}
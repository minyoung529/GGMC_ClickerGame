using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Instrument
{
    public string instName;
    public Sprite instSprite;
    public int money;
    public int moneyPerSec;
    public int popular;
    [TextArea] public string info;
}

[CreateAssetMenu(fileName = "InstrumentSO", menuName = "Sprictable Object/InstrumentSO")]

public class InstrumentSO : ScriptableObject
{
    public Instrument[] instruments;
}
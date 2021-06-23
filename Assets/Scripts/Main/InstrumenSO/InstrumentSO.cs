using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Instrument
{
    public string instName;
    public Sprite sprite;
    public int money;
    public int moneyPerSec;
    public int popular;
}

[CreateAssetMenu(fileName = "InstrumentSO", menuName = "Sprictable Object/InstrumentSO")]

public class InstrumentSO : ScriptableObject
{
    public Instrument[] instruments;
}
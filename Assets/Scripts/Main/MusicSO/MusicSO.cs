using UnityEngine;

[System.Serializable]
public class Music
{
    public string musicName;
    public Sprite musicSprite;
    public int money;
    public int moneyPerSec;
    public int popular;
    [TextArea] public string info;
}

[CreateAssetMenu(fileName = "MusicSO", menuName = "Sprictable Object/MusicSO")]

public class MusicSO : ScriptableObject
{
    public Music[] musics;
}
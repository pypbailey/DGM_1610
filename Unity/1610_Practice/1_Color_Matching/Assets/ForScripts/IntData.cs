using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int nun)
    {
        value += nun;
    }
}

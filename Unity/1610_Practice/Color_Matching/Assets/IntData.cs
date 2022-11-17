using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value;

    public void Updatevalue(int nun)
    {
        value += nun;
    }
}

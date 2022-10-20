using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
   public float value;

   public void SetValue(float nun)
   {
    value = nun;
   }

   public void UpdateValue(float nun)
   {
        value += nun;
   }
}

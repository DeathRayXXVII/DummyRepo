using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void SetValue(float num)
    {
        value = num;
    }

    public void UpdateValue(float num)
    {
        value += num;
    }
    public void CompareValue(FloatData obj)
    {
        if (value <= obj.value )
        {
        }
        else
        {
            value = obj.value;
        }
    }
}

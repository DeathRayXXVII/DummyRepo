using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GamActionSO : ScriptableObject
{
    public UnityAction raise;

    public void RaiseAction()
    {
        raise?.Invoke();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GamActionSO gameActionObj;
    public UnityEvent onRaiseEvent;
    private void Start()
    {
        gameActionObj.raise += Raise;
    }

    public void Raise()
    {
        onRaiseEvent.Invoke();
    }
}

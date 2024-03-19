using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class LockDraggable : MonoBehaviour
{
    
    //    //AnthonyRomrell Module  Matching game 1 code

    
    private Camera cameraObj;
    public bool dragabble;
    public Vector3 position;
    public Vector3 offSet;
    public UnityEvent startDragEvent, endDragEvent;
    
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offSet = transform.position -cameraObj.ScreenToWorldPoint(Input.mousePosition);
        dragabble = true;
        startDragEvent.Invoke();
        
        yield return new WaitForFixedUpdate();


        while (dragabble)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offSet;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        dragabble = false;
        endDragEvent.Invoke();
    }
}


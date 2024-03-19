using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Throw : MonoBehaviour
{
    //    //AnthonyRomrell Module  Matching game 1 code
    
    private Camera cameraObj;
    public bool dragabble;
    public Vector3 position;
    public Vector3 offSet;
    public UnityEvent startDragEvent, endDragEvent, OnCollisonEvent;
    public GameObject player;
    public Vector3 theSpot;
    
    

    
    void Start()
    {
        cameraObj = Camera.main;
        theSpot = new Vector3(-1,-4,0);
        //Physics.IgnoreLayerCollision(0, 8);
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

    public void PlayerMove()
    {
        
        player.transform.position = theSpot;
        //Debug.Log("TheSpot");
        //Debug.Log(player);
        //dragabble = false;   
        
        

    }

}

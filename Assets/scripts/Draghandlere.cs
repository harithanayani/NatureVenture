using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Draghandlere : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
   Transform startParent;

    
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag new Called");
        print(gameObject.name);
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    

    #region IDragHandler implementation

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag Called");
        // transform.position = eventData.position;
        transform.position = Input.mousePosition;
       
    }

    #endregion

    #region IEndDragHandler implementation

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag Called");
        print(gameObject.name);
        
         itemBeingDragged = null;
         GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == startParent)
         {
             Debug.Log("Parent == startParent");
             transform.position = startPosition;
         } 
    }

    #endregion



}


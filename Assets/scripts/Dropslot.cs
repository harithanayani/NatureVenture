using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class Dropslot : MonoBehaviour,IDropHandler {
    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            Debug.Log("iuguigu");
            print(gameObject.name);
            print(eventData.pointerDrag.name);
            Draghandlere.itemBeingDragged.transform.SetParent(transform);
            //ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
        }
    }


}

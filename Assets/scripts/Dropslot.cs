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
    public string GetFlowerForSlot(GameObject gameObj)
    {
        string flowerObj;
        print(gameObj.name);

        if (gameObj.name == "Blueslot")
        {
            print("Current slot is Blueslot");
            flowerObj = "Blueflower";
        }
        else if (gameObj.name == "Pinkslot")
        {
            print("Current slot is Pinkslot");
            flowerObj = "Pinkflower";
        }
        else if (gameObj.name == "Yellowslot")
        {
            print("Current slot is Yellowslot");
            flowerObj = "Yellowflower";
        }
        else
        {
            flowerObj = "UNDEFINED";
            print("Undefined maping");
        }

        return flowerObj;
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            Debug.Log("iuguigu");
            print(gameObject.name);
            print(eventData.pointerDrag.name);
            //Draghandlere.itemBeingDragged.transform.SetParent(transform);
            print(Draghandlere.itemBeingDragged.name);
            /* GetCurrentSlotName */
            string currentSlotName = gameObject.name;
            print(GetFlowerForSlot(gameObject));
            print(currentSlotName);
            if (Draghandlere.itemBeingDragged.name == GetFlowerForSlot(gameObject))
            {
                print("MATCH FOUND");
                Draghandlere.itemBeingDragged.transform.SetParent(transform);
                Destroy(item);
            }

            //Destroy(item);
             }
    }


}

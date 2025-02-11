using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvMgr : MonoBehaviour
{
    public GameObject[] allItems;

    public int currentItemIndex;

    public GameObject getShotType() {
        if(currentItemIndex < 0) {
            return null;
        }
        else {
            return allItems[currentItemIndex];
        }

    }
}

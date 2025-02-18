using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class InvMgr : MonoBehaviour
{
    public GameObject[] allItems;

    public int currentItemIndex;

    Image iconImg;

    void Start()
    {
        iconImg = GameObject.Find("Icon").GetComponent<Image>();   
    }

    public GameObject getShotType() {
        if(currentItemIndex < 0) {
            return null;
        }
        else {
            return allItems[currentItemIndex];
        }

    }

    public void setShotType(int itemIndex)
    {
        currentItemIndex = itemIndex;

        iconImg.enabled = true;

        iconImg.color = Color.blue;
    }
}

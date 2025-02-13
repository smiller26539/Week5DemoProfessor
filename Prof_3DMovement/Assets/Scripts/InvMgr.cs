using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvMgr : MonoBehaviour
{
    public GameObject[] allPossibleItems;
    public int currentItemIndex;

    Image iconImg;

    void Start() {
        iconImg = GameObject.Find("Icon").GetComponent<Image>();
    }

    public GameObject getShotType() {
        if(currentItemIndex < 0) {
            return null;
        }
        else {
            return allPossibleItems[currentItemIndex];
        }
    }

    public void setShotType(int itemIndex, Color c) { // Sprite s
        currentItemIndex = itemIndex;
        //enable icon
        iconImg.enabled = true;
        //set color
        iconImg.color = c;
        // set sprite
        //iconImg.sprite = s;
    }
}

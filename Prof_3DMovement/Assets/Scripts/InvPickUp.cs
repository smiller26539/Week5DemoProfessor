using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InvPickUp : MonoBehaviour
{
    InvMgr inv;

    public int itemIndex;
    public Color iconColor;

    // Start is called before the first frame update
    void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<InvMgr>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += Vector3.up * Time.deltaTime * 180;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;

        if(otherGO.name == "Player") {
            //tell inventory item index
            inv.setShotType(itemIndex, iconColor);
            Destroy(gameObject);
        }
    }

    
}

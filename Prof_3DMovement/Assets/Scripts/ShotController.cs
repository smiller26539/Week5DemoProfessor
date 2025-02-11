using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    // public GameObject bulletPrefab;

    InvMgr inv;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<InvMgr>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject bulletPrefab = inv.getShotType();
        if(bulletPrefab != null && Input.GetButtonDown("Fire1")) {
            GameObject g = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5); //destroy this gameobject after 5 seconds
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnCollisionEnter(Collision collision)
    {
        GameObject otherGO = collision.gameObject;
        if(otherGO.name == "Enemy") {
            Destroy(otherGO);
        }
        //Do Stuff
        //Destroy(gameObject); // destroy this gameobject
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotSpeed;

    private Vector3 myRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float my = Input.GetAxis("Mouse Y");
        Vector3 rotStep = -my * Vector3.right;
        myRot += rotStep * rotSpeed * Time.deltaTime;
        if(myRot.x > 80) myRot.x = 80;
        if(myRot.x < -80) myRot.x = -80;
        transform.localEulerAngles = myRot;        
    }
}

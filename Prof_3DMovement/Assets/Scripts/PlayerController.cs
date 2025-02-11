using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotSpeed;

    private Vector3 myRot;

    CharacterController myCon;

    // Start is called before the first frame update
    void Start()
    {
        myCon = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 step = h * transform.right + v * transform.forward;
        //transform.position += step * speed * Time.deltaTime;
        myCon.Move(step * speed * Time.deltaTime);

        float mx = Input.GetAxis("Mouse X");
        Vector3 rotStep = mx * Vector3.up;
        myRot += rotStep * rotSpeed * Time.deltaTime;
        transform.localEulerAngles = myRot;
    }
}

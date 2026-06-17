using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickuplight : MonoBehaviour
{
    GameObject startTrans; //start transform
    Transform controller;

    static public bool pickedUp = false;

    // Start is called before the first frame update
    void Start()
    {
        startTrans = new GameObject();

        startTrans.transform.position = transform.position;
        startTrans.transform.rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(pickedUp == true)
        {
            transform.position = controller.position;
            transform.rotation = controller.rotation;
        }
        else
        {
            transform.position = startTrans.transform.position;
            transform.rotation = startTrans.transform.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        pickedUp = true;
        controller = other.gameObject.transform;
    }
}

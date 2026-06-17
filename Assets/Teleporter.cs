using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Teleporter : MonoBehaviour
{
    public int raylenght = 10;
    public float delay = 0.1f; // Here f means float?
    bool aboutToTeleport = false;
    Vector3 teleportPos = new Vector3();

    public Material tMat;
    public GameObject pointer;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        OVRInput.SetControllerVibration(0.5f, 0.5f, OVRInput.Controller.RTouch);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(OVRInput.Get(OVRInput.Button.One))
        {
            if(Physics.Raycast(transform.position,transform.forward, out hit, raylenght*10))
            {
                //// press A
                if (hit.collider.gameObject.tag == "Ground")
                {
                    // press A
                    aboutToTeleport = true;
                    teleportPos = hit.point;

                    GameObject myLine = new GameObject();
                    myLine.transform.position = transform.position;
                    myLine.AddComponent<LineRenderer>();

                    LineRenderer lr = myLine.GetComponent<LineRenderer>();
                    lr.material = tMat;

                    lr.startWidth = 0.01f;
                    lr.endWidth = 0.01f;
                    lr.SetPosition(0, transform.position);
                    lr.SetPosition(1, hit.point);
                    GameObject.Destroy(myLine, delay);

                    pointer.transform.position = hit.point;

                }
                else
                {
                    //aboutToTeleport = false;
                    //Vector3 v1 = transform.position;
                    //v1 = transform.TransformPoint(Vector3.forward * raylenght);

                    //GameObject myLine = new GameObject();
                    //myLine.transform.position = transform.position;
                    //myLine.AddComponent<LineRenderer>();

                    //LineRenderer lr = myLine.GetComponent<LineRenderer>();

                    //lr.startColor = new Color(0.2f, 0, 1);
                    //lr.endColor = new Color(1, 0, 0); //red

                    //lr.startWidth = 0.01f;
                    //lr.endWidth = 0.01f;
                    //lr.SetPosition(0, transform.position);
                    //lr.SetPosition(1, v1);
                    //GameObject.Destroy(myLine, delay);

                    ////////////////////////////
                    ///

                    // press A
                    aboutToTeleport = true;
                    teleportPos = hit.point;

                    GameObject myLine = new GameObject();
                    myLine.transform.position = transform.position;
                    myLine.AddComponent<LineRenderer>();

                    LineRenderer lr = myLine.GetComponent<LineRenderer>();
                    lr.material = tMat;

                    lr.startWidth = 0.01f;
                    lr.endWidth = 0.01f;
                    lr.SetPosition(0, transform.position);
                    lr.SetPosition(1, hit.point);
                    GameObject.Destroy(myLine, delay);

                    pointer.transform.position = hit.point;


                }
            }
        }

        if(OVRInput.GetUp(OVRInput.Button.One) && aboutToTeleport == true)
        {
            // Setting player position to teleport position
            aboutToTeleport = false;
            player.transform.position = teleportPos;
        }
    }
}

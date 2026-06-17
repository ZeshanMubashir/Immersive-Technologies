using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviourchange : MonoBehaviour
{
    public static bool batIsInLight;
    // Start is called before the first frame update
    void Start()
    {
        batIsInLight = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Light")
        {
            batIsInLight = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Light")
        {
            batIsInLight = false;
        }
    }
}

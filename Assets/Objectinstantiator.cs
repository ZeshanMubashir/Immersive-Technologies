using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectinstantiator : MonoBehaviour
{
    public GameObject objectToInstantiate;
    public Transform plane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {      
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distanceToPlane;
            if (plane.GetComponent<Collider>().Raycast(ray, out RaycastHit hit, Mathf.Infinity))
            {

                distanceToPlane = hit.distance;
                
            }
            else
            {
                Debug.Log("Hello");
                distanceToPlane = plane.position.y - ray.origin.y;
            }
            Vector3 position = ray.origin + ray.direction * distanceToPlane;
            position += new Vector3(0f, 0f, 100.0f);
            Instantiate(objectToInstantiate, position, Quaternion.identity);
        }
    }
}

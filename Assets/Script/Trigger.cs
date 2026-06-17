using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject bat;
    public float moveSpeed = 5.0f;
    public float turnSpeed = 1.0f;
    public Vector3 targetPosition;


    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Item There");
        // bat.transform.Translate(Vector3.up * 10.0f * Time.deltaTime);
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("Item There");
            //Destroy(bat);
            if (targetPosition == Vector3.zero || Vector3.Distance(bat.transform.position, targetPosition) <= 1.0f)
            {
                targetPosition = Random.insideUnitSphere * 10.0f + bat.transform.position;
                targetPosition.x = bat.transform.position.x;
                //Debug.Log("Item There1");
            }

            targetPosition = Random.insideUnitSphere * 10.0f + bat.transform.position;
            targetPosition.z = bat.transform.position.z;

            Vector3 targetDirection = targetPosition - bat.transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.forward);
            bat.transform.rotation = Quaternion.Slerp(bat.transform.rotation, targetRotation, turnSpeed * Time.deltaTime);

            bat.transform.position = Vector3.MoveTowards(bat.transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
        else
        {
            //Debug.Log("Not There");
        }
    }

   
}

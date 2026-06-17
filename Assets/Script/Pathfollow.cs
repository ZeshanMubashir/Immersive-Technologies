using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfollow : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float turnSpeed = 10.0f;
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 0.9f * Time.deltaTime);
        //Debug.Log("Hello");
    }

    public void OnTriggerStay(Collider other)
    {
        if (gameObject.CompareTag("Player"))
        {
            if (targetPosition == Vector3.zero || Vector3.Distance(transform.position, targetPosition) <= 1.0f)
            {
                targetPosition = Random.insideUnitSphere * 10.0f + transform.position;
                targetPosition.x = transform.position.x;
            }
            Debug.Log("Item There1");
            Vector3 targetDirection = targetPosition - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);

            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }

}

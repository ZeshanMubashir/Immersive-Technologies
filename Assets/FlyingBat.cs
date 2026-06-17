using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBat : MonoBehaviour
{
    public float moveafterseconds = 0.0f;
    public float moveSpeed = 0;
    public float rotateAngle = 0;
    Quaternion target;
    // Start is called before the first frame update
    void Start()
    {
        rotateAngle = 6;
        moveafterseconds = 2.0f;
        StartCoroutine(changemovespeedN());
        StartCoroutine(changerotationN());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.Self);
        //Debug.Log(moveSpeed + "  " + rotateAngle);
        
        if (Behaviourchange.batIsInLight == true)
        {
            StopCoroutine(changemovespeedN());
            StopCoroutine(changerotationN());
            //Debug.Log(Behaviourchange.batIsInLight);
            StartCoroutine(changemovespeedA());
            StartCoroutine(changerotationA());
        }
        else if(Behaviourchange.batIsInLight == false)
        {
            StopCoroutine(changemovespeedA());
            StopCoroutine(changerotationA());

            StartCoroutine(changemovespeedN());
            StartCoroutine(changerotationN());
        }
    }

     
   IEnumerator changemovespeedN()
    {
        //moveSpeed = Random.Range(4, 6);
        //moveafterseconds = Random.Range(8, 10);
        //yield return new WaitForSeconds(moveafterseconds);
        //StartCoroutine(changemovespeedN());

        float newSpeed = Random.Range(4, 6);
        float time = 0;
        float duration = Random.Range(4, 6);
        float startSpeed = moveSpeed;

        while (time < duration)
        {
            moveSpeed = Mathf.Lerp(startSpeed, newSpeed, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        moveSpeed = newSpeed;
        StartCoroutine(changemovespeedN());
    }
    IEnumerator changemovespeedA()
    {
        //moveSpeed = Random.Range(10, 12);
        //moveafterseconds = Random.Range(6, 9);
        //yield return new WaitForSeconds(moveafterseconds);
        //StartCoroutine(changemovespeedA());
        float newSpeed = Random.Range(5, 7);
        float time = 0;
        float duration = Random.Range(3, 4);
        float startSpeed = moveSpeed;

        while (time < duration)
        {
            moveSpeed = Mathf.Lerp(startSpeed, newSpeed, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        moveSpeed = newSpeed;
        StartCoroutine(changemovespeedA());
    }

    IEnumerator changerotationN()
    {
        //rotateAngle = Random.Range(-60, 60);
        //transform.eulerAngles = new Vector3(0, (rotateAngle), 0);
        //moveafterseconds = Random.Range(8, 10);
        //yield return new WaitForSeconds(moveafterseconds);
        //StartCoroutine(changerotationN());
        float newAngle = Random.Range(-60, 60);
        float time = 0;
        float duration = Random.Range(4, 6);
        Quaternion startRotation = transform.rotation;
        target = Quaternion.Euler(0, newAngle, 0);

        while (time < duration)
        {
            transform.rotation = Quaternion.Lerp(startRotation, target, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        transform.rotation = target;
        StartCoroutine(changerotationN());
    }
    IEnumerator changerotationA()
    {
        //rotateAngle = Random.Range(-60, 60);
        //transform.eulerAngles = new Vector3(0, (rotateAngle), 0);
        //moveafterseconds = Random.Range(3, 4);
        //yield return new WaitForSeconds(moveafterseconds);
        //StartCoroutine(changerotationA());
        float newAngle = Random.Range(-60, 60);
        float time = 0;
        float duration = Random.Range(3, 4);
        Quaternion startRotation = transform.rotation;
        target = Quaternion.Euler(0, newAngle, 0);

        while (time < duration)
        {
            transform.rotation = Quaternion.Lerp(startRotation, target, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        transform.rotation = target;
        StartCoroutine(changerotationA());
    }

}

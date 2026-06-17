using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatsInstantiate : MonoBehaviour
{
    public GameObject bat;
    public Transform[] spawnPoints;
    public int numberofbats = 0;
    public float seperationfactor = 5;
    // Start is called before the first frame update
    void Start()
    {
        instantiatebat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void instantiatebat()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            for (int x = 0; x < numberofbats; x++)
            {
                Vector3 offset = spawnPoints[i].forward * seperationfactor;
                Instantiate(bat, spawnPoints[i].position + offset, Quaternion.identity);
            }
        } 
    }
}

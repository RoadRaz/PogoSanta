using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateClouds : MonoBehaviour
{
    public GameObject cloudpref;
    public int numclouds;
    public float horizontalScope = 10f;
    public float minV = 1f;
    public float maxV = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnCloud = new Vector3();

        for (int i = 0; i < numclouds; i++)
        {
            spawnCloud.y += Random.Range(minV, maxV);
            spawnCloud.x = Random.Range(-horizontalScope, horizontalScope);
            Instantiate(cloudpref, spawnCloud, Quaternion.identity);
        }
    }
}

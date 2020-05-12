using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject platformpref;
    public int numOfPlatforms;
    public float horizontalScope = 3f;
    public float minY = 1f;
    public float maxY = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosi = new Vector3();

        for(int i = 0; i < numOfPlatforms; i++)
        {
            spawnPosi.y += Random.Range(minY, maxY);
            spawnPosi.x = Random.Range(-horizontalScope, horizontalScope);
            Instantiate(platformpref, spawnPosi, Quaternion.identity);
        }
    }
}

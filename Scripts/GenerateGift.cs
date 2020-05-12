using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGift : MonoBehaviour
{
    public GameObject giftpref;
    public int numberOfGifts;
    public float horizontalScope = 5f;
    public float minV = 1f;
    public float maxV = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnGift = new Vector3();

        for (int i = 0; i < numberOfGifts; i++)
        {
            spawnGift.y += Random.Range(minV, maxV);
            spawnGift.x = Random.Range(-horizontalScope, horizontalScope);
            Instantiate(giftpref, spawnGift, Quaternion.identity);
        }
    }
}

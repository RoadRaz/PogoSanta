using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftPickup : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            SoundScript.playTune("pickUp");
            ScoreScript.scoreVal += 30;
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);    
    }
}

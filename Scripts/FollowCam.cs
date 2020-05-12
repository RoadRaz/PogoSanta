using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform targetCharacter;

    // Update is called once per frame
    void Update()
    {
        if (targetCharacter.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, targetCharacter.position.y, transform.position.z);
            transform.position = newPosition;
        }
    }
}

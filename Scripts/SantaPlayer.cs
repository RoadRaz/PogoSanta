using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SantaPlayer : MonoBehaviour
{
    public float speed = 10f;
    public float fellRight = 8f;
    public float fellLeft = -8f;

    float movement = 0f;

    Rigidbody2D ribo;

    // Start is called before the first frame update
    void Start()
    {
        ribo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * speed;
    }

    void FixedUpdate()
    {
        /*if (transform.position.x > fellRight)
        {
            transform.position = new Vector2(fellLeft, transform.position.y);
        }
        if (transform.position.x > fellLeft)
        {
            transform.position = new Vector2(fellRight, transform.position.y);
        }*/
        Vector2 velocity = ribo.velocity;
        velocity.x = movement;
        ribo.velocity = velocity;
    }

    void OnBecameInvisible()
    {
        SoundScript.playTune("santaFell");
    }

}

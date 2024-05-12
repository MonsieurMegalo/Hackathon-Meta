using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;
    public float speed = 5f;

    void Update()
    {
        if (gameObject.name.Contains("Left"))
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                GameObject spawnedBall = Instantiate(ball, transform.position, Quaternion.identity);
                Rigidbody ballRb = spawnedBall.GetComponent<Rigidbody>();
                ballRb.velocity = transform.forward * speed;
            }
        }
        else if (gameObject.name.Contains("Right"))
        {
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                GameObject spawnedBall = Instantiate(ball, transform.position, Quaternion.identity);
                Rigidbody ballRb = spawnedBall.GetComponent<Rigidbody>();
                ballRb.velocity = transform.forward * speed;
            }
        }

    }
}

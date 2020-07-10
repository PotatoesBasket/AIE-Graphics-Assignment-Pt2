using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public Rigidbody ball;
    public Transform spawnPoint;

    public void Move()
    {
        ball.isKinematic = true;
        ball.transform.position = spawnPoint.position;
        ball.isKinematic = false;
    }
}
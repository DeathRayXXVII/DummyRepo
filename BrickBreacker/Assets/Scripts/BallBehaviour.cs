using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using Random = System.Random;


public class BallBehaviour : MonoBehaviour
{
    // Helped made this scripted with this https://www.youtube.com/watch?v=RYG8UExRkhA Specifically and only with the ball movement chapter
    
    // Lecture told me that i should put a bouncy thing on my paddle or off my paddle i dont fully recall
    public Rigidbody rb;
    public float speed = 500f;
    public UnityEvent collide;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        

    }

    private void Start()
    {
        
        Invoke(nameof(SetRandomTrajectory), 1f);
        
    }

    private void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * speed;

    }

    private void SetRandomTrajectory()
    {
        Vector3 force = Vector3.zero;
        force.x = UnityEngine.Random.Range(-1f, 1f); // Fixed it with UnityEngine
        force.y = -1f;
        
        rb.AddForce(force.normalized * speed, ForceMode.Impulse);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            collide.Invoke();
        }
    }
}

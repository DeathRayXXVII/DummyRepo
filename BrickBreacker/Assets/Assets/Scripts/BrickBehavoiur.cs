using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBehavoiur : MonoBehaviour
{
    
    //Made by Riley
    public float maxBounceAngle = 75.0f;
    public float health = 1f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        BallBehaviour ball = collision.gameObject.GetComponent<BallBehaviour>();

        if (ball != null)
        {
            Vector3 paddlePosition = transform.position;
            Vector2 ballPosition = collision.transform.position;

            float offset = paddlePosition.x - ballPosition.x;
            float width = collision.collider.bounds.size.x / 2;

            float currentAngle = Vector2.SignedAngle(Vector2.up, ball.rb.velocity);
            float bounceAngle = (offset / width) * maxBounceAngle;
            float newAngle = Mathf.Clamp(currentAngle + bounceAngle, -maxBounceAngle, maxBounceAngle);

            Quaternion rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
            ball.rb.velocity = rotation * Vector2.up * ball.rb.velocity.magnitude;
        }

        if (ball)
        {
            health--;
            if (health <= 0)
            {
                gameObject.SetActive(false);
            }
        }
    }

    public void BrickRestart()
    {
        gameObject.SetActive(true);
    }
}


using UnityEngine;

public class Platform : MonoBehaviour
{
    private float _jumpForce;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.y <= 0)
        { 
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            { 
                Vector3 velocity = rb.velocity;
                velocity.y = _jumpForce;
                rb.velocity = velocity;
            }
        }
    }
}

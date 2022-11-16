using UnityEngine;

public class Platform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.tag == "Gray")
        {
            var _jumpSphere = collision.gameObject.GetComponent<JumpSphere>();
            _jumpSphere.Jump();
        }
        else
        {
            var _jumpSphere = collision.gameObject.GetComponent<JumpSphere>();
            _jumpSphere.IsAlive(false);
        }
        
    }
}

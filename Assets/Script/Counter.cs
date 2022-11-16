using UnityEngine;

public class Counter : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            var _jumpSphere = other.gameObject.GetComponent<JumpSphere>();
            _jumpSphere._counterPassed++;
            _jumpSphere.CounterPassed();
            Destroy(this.gameObject);
        }
    }
}

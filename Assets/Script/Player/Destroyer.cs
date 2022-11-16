using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Red" || other.gameObject.tag == "Gray")
            Destroy(other.gameObject);
    }
}

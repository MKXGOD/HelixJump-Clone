using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]private Transform target;
    public float smooth = 0f;
    private Vector3 offset;

    void Start()
    {
         offset = transform.position - target.position; 
    }
    void LateUpdate()
    {
        Vector3 pos = Vector3.Lerp(transform.position, target.position + offset, smooth);
        transform.position = pos; 
    }
}

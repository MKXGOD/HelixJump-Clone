using UnityEngine;

public class RotationCylinder : MonoBehaviour
{
    [SerializeField] private float _speed = 200;
    private void HorizontalMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal * _speed * Time.deltaTime,0);
    }
    private void Update()
    {
        HorizontalMove();
    }
}
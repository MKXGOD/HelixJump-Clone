using UnityEngine;
using UnityEngine.EventSystems;

public class RotationCylinder : MonoBehaviour
{
    [SerializeField] private float _speed = 25;

    private Vector2 _startPosition;
    private float _deltaX;
    private void Update()
    {
        HorizontalMove();
    }
    private void HorizontalMove()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    _startPosition.x = touch.position.x;
                    break;
                case TouchPhase.Moved:
                    _deltaX = touch.position.x - _startPosition.x;
                    _startPosition.x = touch.position.x;
                    transform.Rotate(0, -_deltaX * _speed * Time.deltaTime, 0);
                    break;
            }
        }
    }

    private bool ClickOverUI()
    {
#if (UNITY_ANDROID) && (!UNITY_EDITOR)
        int cursorID = Input.GetTouch(0).fingerId;
        return EventSystem.current.IsPointerOverGameObject(cursorID);
#else
        return EventSystem.current.IsPointerOverGameObject();
#endif
    }
}
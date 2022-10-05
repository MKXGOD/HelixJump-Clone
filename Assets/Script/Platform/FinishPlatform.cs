using System;
using UnityEngine;

public class FinishPlatform : MonoBehaviour
{
    public static event Action ActionFinished;

    public void OnCollisionEnter(Collision collision)
    {
        ActionFinished?.Invoke();
    }
}

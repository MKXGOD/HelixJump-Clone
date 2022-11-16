using System;
using UnityEngine;

public class JumpSphere : MonoBehaviour
{
    public static event Action<bool> ActionIsDie;

    [SerializeField]private GenerationLevel _generationLevel;

    private Bank _bank;
    private Rigidbody _rb;

    [HideInInspector]public int _counterPassed = 0;

    private float _jumpForce = 6;
    private void Awake()
    {
        _bank = new Bank();
        _rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {  
        IsAlive(true);
    }
    public bool IsAlive(bool state)
    {
        ActionIsDie?.Invoke(state);
        return state;
    }
    public void Jump()
    {
        _counterPassed = 0;

        Vector3 velocity = _rb.velocity;
        velocity.y = _jumpForce;
        _rb.velocity = velocity;
        
    }
    public void CounterPassed()
    {
        if (_counterPassed > 2)
        {
            _bank.AddScore(FallingMultiplyScore.MultiplyScore(_generationLevel.ScorePerLevel, _counterPassed));
        }
        else _bank.AddScore(_generationLevel.ScorePerLevel);
    }
}

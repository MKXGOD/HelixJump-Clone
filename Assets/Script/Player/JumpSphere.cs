using UnityEngine;

public class JumpSphere : MonoBehaviour
{
    private Bank _bank;
    private GenerationLevel _generationLevel;


    private void Start()
    {
        _bank = new Bank();
        _generationLevel = new GenerationLevel();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Counter")
        {
            _bank.AddScore(_generationLevel.Level);
            Destroy(other.gameObject);
        }

    }
}

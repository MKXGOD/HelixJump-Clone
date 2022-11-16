using UnityEngine;
using UnityEngine.UI;

public class LevelPanel : MonoBehaviour
{
    [SerializeField]private Text _level;
    [SerializeField]private GenerationLevel _generationLevel;

    private void Start()
    {
        _level.text = "Level: " + _generationLevel.Level;
    }
}

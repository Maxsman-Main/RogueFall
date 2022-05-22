using UnityEngine;

public class LevelMaker : MonoBehaviour
{
    [SerializeField] private Level _levelPattern;

    private Level _level;
    
    public Level Level => _level;
    
    public void MakeLevel()
    {
        _level = Instantiate(_levelPattern);
    }

    public void DestroyLevel()
    {
        Destroy(_level);
    }
}

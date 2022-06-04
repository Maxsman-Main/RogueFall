using UnityEngine;
using System.Collections.Generic;

public class LevelMaker : MonoBehaviour
{
    [SerializeField] private List<Level> _levelPatterns;
    [SerializeField] private int _currentLevelIndex;

    private Level _level;
    
    public int CurrentLevelIndex => _currentLevelIndex;
    
    public Level Level => _level;
    
    public void MakeLevel()
    {
        if (_level != null)
        {
            DestroyLevel();
        }
        _level = Instantiate(_levelPatterns[_currentLevelIndex]);
        
        _level.Portal.OnPortalTriggered += IncreaseLevelIndex;
        _level.Portal.OnPortalTriggered += MakeLevel;
        _level.Portal.SetExitPoint(_levelPatterns[(_currentLevelIndex + 1) % _levelPatterns.Count].StartPosition);
    }

    public void DestroyLevel()
    {
        Destroy(_level.gameObject);
    }

    private void IncreaseLevelIndex()
    {
        _currentLevelIndex = (_currentLevelIndex + 1) % _levelPatterns.Count;
    }
}

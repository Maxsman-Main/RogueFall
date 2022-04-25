using System;

public class PlayerParameter
{
    private string _parameterName;
    private int _level;
    private int _price;
    
    public string Name => _parameterName;
    public int Level => _level;
    public int Price => _price;

    public event Action<int> OnLevelChanged;

    public PlayerParameter(string name, int price)
    {
        _level = 1;
        _parameterName = name;
        _price = price;
    }
    
    public void LevelUp()
    {
        _level += 1;
        OnLevelChanged?.Invoke(_level);
    }
}
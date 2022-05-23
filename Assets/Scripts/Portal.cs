using UnityEngine;

public class Portal : MonoBehaviour
{
    private Transform _exitPoint; 
    
    public delegate void LevelMakerAction();

    public event LevelMakerAction OnPortalTriggered;

    public void SetExitPoint(Transform point)
    {
        _exitPoint = point;
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.TryGetComponent(out Player player))
        {
            OnPortalTriggered?.Invoke();
            player.TranslatePlayer(_exitPoint);
        }
    }
}

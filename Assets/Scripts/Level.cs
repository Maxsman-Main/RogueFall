using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] Transform _startPosition;

    public Transform StartPosition => _startPosition;
}

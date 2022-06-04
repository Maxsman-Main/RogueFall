using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private Transform _startPosition;
    [SerializeField] private Portal _portal;

    public Transform StartPosition => _startPosition;
    public Portal Portal => _portal;
}

using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovableActor : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    public float Speed => _speed;
    public Rigidbody2D RigidBody => GetComponent<Rigidbody2D>();
}
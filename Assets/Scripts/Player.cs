using Attack;
using Move;
using UnityEngine;

[RequireComponent(typeof(AttackActor))]
[RequireComponent(typeof(JumpingActor))]
[RequireComponent(typeof(MovableActor))]
public class Player : MonoBehaviour
{
    [SerializeField] private AttackPlace _attackPlace;
    
    private AttackActor _attackActor;
    
    private void Start()
    {
        _attackActor = GetComponent<AttackActor>();
        _attackActor.SetAttackBehavior(new MeleeAttack(_attackPlace, 0.1f));
    }
}
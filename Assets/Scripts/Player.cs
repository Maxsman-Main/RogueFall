using Attack;
using Move;
using UI;
using UnityEngine;

[RequireComponent(typeof(AttackActor))]
[RequireComponent(typeof(JumpingActor))]
[RequireComponent(typeof(MovableActor))]
[RequireComponent(typeof(Health))]
[RequireComponent(typeof(Cash))]
public class Player : MonoBehaviour
{
    [SerializeField] private AttackPlace _attackPlace;
    [SerializeField] private int _damage;
    [SerializeField] private HealthView _healthView;
    [SerializeField] private float _cashValuePower;
    [SerializeField] private CashView _cashView;
    
    private AttackActor _attackActor;
    private Health _health;
    private Cash _cash;
    
    private void Start()
    {
        _cash = gameObject.GetComponent<Cash>();
        _attackActor = GetComponent<AttackActor>();
        _attackActor.SetAttackBehavior(new MeleeAttack(_attackPlace, 0.1f, _damage));
        _attackActor.SetCashUpdater(new CashUpdater(_attackPlace, 0.1f, _cashValuePower, _cash));
        _health = gameObject.GetComponent<Health>();
        _health.OnHealthChanged += _healthView.ChangeHealthView;
        _cash.OnCashChanged += _cashView.ChangeCashView;
    }
}
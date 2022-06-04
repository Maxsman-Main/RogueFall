using Attack;
using DefaultNamespace;
using Move;
using PlayerStats;
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
    [SerializeField] private PlayerParameters _parameters;
    [SerializeField] private SaveSystem _saveSystem;
    
    private AttackActor _attackActor;
    private Health _health;
    private Cash _cash;

    public PlayerParameters Parameters => _parameters;
    
    private void Start()
    {
        _saveSystem.Load();
        _cash = gameObject.GetComponent<Cash>();
        _attackActor = GetComponent<AttackActor>();
        _attackActor.SetAttackBehavior(new MeleeAttack(_attackPlace, 0.1f, _damage));
        _attackActor.SetCashUpdater(new CashUpdater(_attackPlace, 0.1f, _cashValuePower, _cash));
        _health = gameObject.GetComponent<Health>();
        _health.OnHealthChanged += _healthView.ChangeHealthView;
        _cash.OnCashChanged += _cashView.ChangeCashView;
        _health.SetHealth(_parameters.Items[0]);
        SetParameters();
    }

    public void TranslatePlayer(Transform point)
    {
        gameObject.transform.position = point.position;
    }

    private void SetParameters()
    {
        _parameters.Items[0].OnUpgraded += _health.SetHealth;
        _parameters.Items[1].OnUpgraded += SetCashPower;
        _parameters.Items[2].OnUpgraded += gameObject.GetComponent<MovableActor>().SetSpeed;
    }

    private void SetCashPower(Parameter parameter)
    {
        _cashValuePower = (float)parameter.Value;
        _attackActor.SetCashUpdater(new CashUpdater(_attackPlace, 0.1f, _cashValuePower, _cash));
    }
}
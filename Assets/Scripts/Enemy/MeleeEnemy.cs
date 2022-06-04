using UnityEngine;
using Attack;

namespace Enemy
{
    public class MeleeEnemy : Enemy
    {
        [SerializeField] private AttackPlace _attackPlace;
        [SerializeField] private float _attackRange;
        [SerializeField] private float _damage;
        
        private void Start()
        {
            SetBehavior(new MeleeAttack(_attackPlace, _attackRange, _damage));
            ChangeState(new Patrol(this));
        }
    }
}

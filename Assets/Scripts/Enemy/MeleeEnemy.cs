using UnityEngine;
using Attack;

namespace Enemy
{
    public class MeleeEnemy : Enemy
    {
        [SerializeField] private AttackPlace _attackPlace;
        [SerializeField] private float _attackRange;
        
        private void Start()
        {
            SetBehavior(new MeleeAttack(_attackPlace, _attackRange));
            ChangeState(new Patrol(this));
        }
    }
}

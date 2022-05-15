using System.Threading.Tasks;
using UnityEngine;

namespace Attack
{
    public class MeleeAttack : IAttackBehavior
    {
        private readonly AttackPlace _attackPlace;
        private readonly float _attackRadius;
        private readonly LayerMask _damagedLayer;
        private readonly float _damage;

        public MeleeAttack(AttackPlace attackPlace, float attackRadius, float damage)
        {
            _attackPlace = attackPlace;
            _attackRadius = attackRadius;
            _damagedLayer = LayerMask.NameToLayer("Enemy");
            _damage = damage;
        }

        public void Attack()
        {
            if (_attackPlace != null)
            {
                AttackWithDelay(100);
            }
        }

        private async void AttackWithDelay(int attackDelay)
        {
            Collider2D[] enemies =
                Physics2D.OverlapCircleAll(_attackPlace.transform.position, _attackRadius, 1 << _damagedLayer);
            _attackPlace.gameObject.SetActive(true);
            foreach (var enemy in enemies)
            {
                if (enemy.isTrigger == false)
                {
                    var attackHandler = enemy.GetComponent<AttackHandler>();
                    if (attackHandler != null)
                    {
                        attackHandler.GetDamage(_damage);
                    }
                }
            }

            await Task.Delay(attackDelay);
            if (_attackPlace != null)
            {
                _attackPlace.gameObject.SetActive(false);
            }
        }
    }
}
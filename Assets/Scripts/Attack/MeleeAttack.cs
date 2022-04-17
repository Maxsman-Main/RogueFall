using System.Threading.Tasks;
using UnityEngine;

namespace Attack
{
    public class MeleeAttack : IAttackBehavior
    {
        private readonly AttackPlace _attackPlace;
        private readonly float _attackRadius;
        private readonly LayerMask _damagedLayer;
        
        public MeleeAttack(AttackPlace attackPlace, float attackRadius)
        {
            _attackPlace = attackPlace;
            _attackRadius = attackRadius;
            _damagedLayer = LayerMask.NameToLayer("Enemy");
        }
        
        public void Attack()
        {
            AttackWithDelay(100);
        }

        private async void AttackWithDelay(int attackDelay)
        {
            Collider2D[] enemies = Physics2D.OverlapCircleAll(_attackPlace.transform.position, _attackRadius, 1 <<_damagedLayer);
            _attackPlace.gameObject.SetActive(true);
            foreach (var enemy in enemies)
            {
                enemy.GetComponent<AttackHandler>().GetDamage();
            }
            await Task.Delay(attackDelay);
            _attackPlace.gameObject.SetActive(false);
        }
    }
}
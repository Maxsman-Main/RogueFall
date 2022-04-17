using System.Collections;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Attack
{
    public class MeleeAttack : IAttackBehavior
    {
        private readonly AttackPlace _attackPlace;
        
        public MeleeAttack(AttackPlace attackPlace)
        {
            _attackPlace = attackPlace;
        }
        
        public void Attack()
        {
            AttackWithDelay(100, _attackPlace);
        }

        private async void AttackWithDelay(int attackDelay, AttackPlace attackPlace)
        {
            _attackPlace.gameObject.SetActive(true);
            await Task.Delay(attackDelay);
            _attackPlace.gameObject.SetActive(false);
        }
    }
}
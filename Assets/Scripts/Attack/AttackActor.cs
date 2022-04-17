using UnityEngine;

namespace Attack
{
    public class AttackActor : MonoBehaviour
    {
        private IAttackBehavior _attackBehavior;
        
        public void Attack()
        {
            _attackBehavior.Attack();
        }

        public void SetAttackBehavior(IAttackBehavior attackBehavior)
        {
            _attackBehavior = attackBehavior;
        }
    }
}

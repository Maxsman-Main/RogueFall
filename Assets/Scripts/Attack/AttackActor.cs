using UnityEngine;

namespace Attack
{
    public class AttackActor : MonoBehaviour
    {
        private IAttackBehavior _attackBehavior;
        private CashUpdater _cashUpdater;
        
        public void Attack()
        {
            _cashUpdater.Farm();
            _attackBehavior.Attack();
        }

        public void SetAttackBehavior(IAttackBehavior attackBehavior)
        {
            _attackBehavior = attackBehavior;
        }

        public void SetCashUpdater(CashUpdater updater)
        {
            _cashUpdater = updater;
        }
    }
}

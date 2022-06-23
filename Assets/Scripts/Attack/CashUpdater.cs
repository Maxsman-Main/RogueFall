using UnityEngine;

namespace Attack
{
    public class CashUpdater
    {
        private readonly AttackPlace _attackPlace;
        private readonly float _attackRadius;
        private readonly LayerMask _damagedLayer;
        private readonly float _cashValue;
        private Cash _cash;

        public CashUpdater(AttackPlace place, float radius, float cashValue, Cash cash)
        {
            _attackPlace = place;
            _attackRadius = radius;
            _cashValue = cashValue;
            _cash = cash;
            _damagedLayer = LayerMask.NameToLayer("Enemy");
        }

        public void Farm()
        {
            Collider2D[] enemies =
                Physics2D.OverlapCircleAll(_attackPlace.transform.position, _attackRadius, 1 << _damagedLayer);

            foreach (var enemy in enemies)
            {
                if (enemy.isTrigger == false)
                {
                    _cash.GetCash(_cashValue);
                }
            }
        }
    }
}
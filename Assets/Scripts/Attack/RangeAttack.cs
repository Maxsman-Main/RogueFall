using UnityEngine;

namespace Attack
{
    public class RangeAttack : IAttackBehavior
    {
        private readonly AmmoSpawner _spawner;
        private Transform _localScale;
        
        
        public RangeAttack(AmmoSpawner spawner, Transform localScale)
        {
            _spawner = spawner;
            _localScale = localScale;
        }

        public void Attack()
        {
            _spawner.Spawn(_localScale);
        }
}
}
using UnityEngine;

namespace Attack
{
    public class RangeAttack : IAttackBehavior
    {
        private AmmoSpawner _spawner;
        private float _waitTime;
        private float _timer;

        public RangeAttack(AmmoSpawner spawner)
        {
            _spawner = spawner;
            _waitTime = 2f;
            _timer = 0;
        }

        public void Attack()
        {
            _timer += Time.deltaTime;
            if (_waitTime < _timer)
            {
                _spawner.Spawn();
                _timer = 0;
            }
        }
    }
}
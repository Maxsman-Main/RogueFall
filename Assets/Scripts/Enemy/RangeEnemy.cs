using Attack;
using UnityEngine;

namespace Enemy
{
    public class RangeEnemy : Enemy
    {
        [SerializeField] private AmmoSpawner _spawner;
        
        private void Start()
        {
            SetBehavior(new RangeAttack(_spawner));
            ChangeState(new Patrol(this));
        }
    }
}
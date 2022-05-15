using Attack;
using UnityEngine;

namespace Enemy
{
    public class RangeEnemy : Enemy
    {
        [SerializeField] private AmmoSpawner _spawner;
        
        private void Start()
        {
            SetBehavior(new RangeAttack(_spawner, gameObject.transform));
            ChangeState(new Patrol(this));
        }
    }
}
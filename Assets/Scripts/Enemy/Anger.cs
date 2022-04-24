using UnityEngine;
using Attack;

namespace Enemy
{
    public class Anger : State
    {
        private IAttackBehavior _behavior;
        private Transform _target;
        private Enemy _actor;

        public Anger(Enemy actor, IAttackBehavior behavior)
        {
            _actor = actor;
            _behavior = behavior;
        }
        
        public override void Entry()
        {
        }

        public override void Update()
        {
            _behavior.Attack();
            if (!_actor.IsFoundEnemy)
            {
                _actor.ChangeState(new Patrol(_actor));
            }
        }

        public override void Exit()
        {
        }
    }
}

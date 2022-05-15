using UnityEngine;
using Attack;

namespace Enemy
{
    public class Anger : State
    {
        private IAttackBehavior _behavior;
        private GameObject _target;
        private Enemy _actor;
        private float _timer = 0;
        private float _waitTime = 1;

        public Anger(Enemy actor, IAttackBehavior behavior, GameObject target)
        {
            _actor = actor;
            _behavior = behavior;
            _target = target;
        }
        
        public override void Entry()
        {
        }

        public override void Update()
        {
            _timer += Time.deltaTime;
            if (_waitTime < _timer)
            {
                _behavior.Attack();
                _timer = 0;
            }
            if (!_actor.IsFoundEnemy)
            {
                _actor.ChangeState(new Patrol(_actor));
            }

            if (_target != null)
            {
                if (_target.transform.position.x > _actor.transform.position.x && _actor.Side == Side.Left)
                {
                    _actor.Rotate();
                }

                if (_target.transform.position.x < _actor.transform.position.x && _actor.Side == Side.Right)
                {
                    _actor.Rotate();
                }
            }
        }

        public override void Exit()
        {
        }
    }
}

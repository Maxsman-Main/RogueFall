using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace Enemy
{
    public class Patrol : State
    {
        readonly Enemy _actor;
        
        private PatrolPoint _nextPoint;
        private Transform _actorTransform;
        private float _waitTime;
        
        public Patrol(Enemy actor)
        {
            _actor = actor;
        }
        
        public override void Entry()
        {
            _nextPoint = _actor.Points[GetRandomIndex(0, _actor.Points.Count - 1)];
            _actorTransform = _actor.transform;
            _waitTime = 3f;
        }

        public override void Update()
        {
            _actorTransform.position = Vector3.MoveTowards(_actorTransform.position, 
                _nextPoint.transform.position,
                _actor.Speed * Time.deltaTime);

            if (Vector2.Distance(_actorTransform.position, _nextPoint.transform.position) < 0.2f)
            {
                if (_waitTime > 0)
                {
                    _waitTime -= Time.deltaTime;
                }
                else
                {
                    _waitTime = 3f;
                    _nextPoint = _nextPoint = _actor.Points[GetRandomIndex(0, _actor.Points.Count - 1)];
                }
            }

            if (_actor.IsFoundEnemy)
            {
                _actor.ChangeState(new Anger(_actor, _actor.AttackBehavior));
            }
        }

        public override void Exit()
        {
        }

        private int GetRandomIndex(int start, int last)
        {
            Random generator = new Random();
            return generator.Next(start, last + 1);
        }
    }
}

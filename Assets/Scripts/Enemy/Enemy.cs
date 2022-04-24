using System;
using System.Collections.Generic;
using Attack;
using UnityEngine;
using UnityEngine.XR;

namespace Enemy
{
    public enum Side
    {
        Left,
        Right
    }
    public abstract class Enemy : StateMachine
    {
        [SerializeField] private List<PatrolPoint> _points;
        [SerializeField] private float _speed;
        
        private bool _isFoundEnemy;
        private IAttackBehavior _behavior;
        
        public bool IsFoundEnemy => _isFoundEnemy;
        public List<PatrolPoint> Points => _points;
        public float Speed => _speed;
        public IAttackBehavior AttackBehavior => _behavior;

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent(out Player player))
            {
                _isFoundEnemy = true;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out Player player))
            {
                _isFoundEnemy = false;
            }
        }

        protected void SetBehavior(IAttackBehavior behavior)
        {
            _behavior = behavior;
        }

        public void Rotate(Side side)
        {
            gameObject.transform.localScale = side == Side.Left ? new Vector3(-1,1,1) : new Vector3(1, 1, 1);
        }
    }
}

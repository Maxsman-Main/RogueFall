using System.Collections.Generic;
using Attack;
using JetBrains.Annotations;
using UnityEngine;

namespace Enemy
{
    public enum Side
    {
        Left,
        Right
    }
    
    [RequireComponent(typeof(Health))]
    public abstract class Enemy : StateMachine
    {
        [SerializeField] private List<PatrolPoint> _points;
        [SerializeField] private float _speed;
        
        private Health _health;
        private bool _isFoundEnemy;
        private IAttackBehavior _behavior;
        private GameObject _target = null;
        private Side _side = Side.Left;
        
        [CanBeNull] public GameObject Target => _target;
        public bool IsFoundEnemy => _isFoundEnemy;
        public List<PatrolPoint> Points => _points;
        public float Speed => _speed;
        public IAttackBehavior AttackBehavior => _behavior;
        public Side Side => _side;

        private void Awake()
        {
            _health = gameObject.GetComponent<Health>();
            _health.OnHealthChanged += TryDied;
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent(out Player player))
            {
                _isFoundEnemy = true;
                _target = col.gameObject;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out Player player))
            {
                _isFoundEnemy = false;
                _target = other.gameObject;
            }
        }

        private void TryDied(float health)
        {
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }

        protected void SetBehavior(IAttackBehavior behavior)
        {
            _behavior = behavior;
        }

        public void Rotate()
        {
            gameObject.transform.localScale = _side == Side.Left ? new Vector3(-1,1,1) : new Vector3(1, 1, 1);
            _side = _side == Side.Left ? Side.Right : Side.Left;
        }
    }
}

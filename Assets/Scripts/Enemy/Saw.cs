using System;
using Attack;
using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Enemy
{
    public class Saw : MonoBehaviour
    {
        [SerializeField] private float _damage;
        [SerializeField] private List<PatrolPoint> _points;
        [SerializeField] private float _speed;
        GameObject player;
        private int _currentPointIndex;
        
        private void Start()
        {
            _currentPointIndex = 0;
            player = GameObject.FindGameObjectWithTag("Player");
        }
        private async void displayDamage()
        {
            if (player.GetComponent<SpriteRenderer>() != null)
            {
                player.GetComponent<SpriteRenderer>().color = Color.red;
            }

            await Task.Delay(100);

            if (player.gameObject.GetComponent<SpriteRenderer>() != null)
            {
                player.GetComponent<SpriteRenderer>().color = Color.white;
            }

        }

        private void Update()
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, 
                _points[_currentPointIndex].transform.position,
                _speed * Time.deltaTime);
            
            if (Vector2.Distance(gameObject.transform.position, _points[_currentPointIndex].transform.position) < 0.2f)
            {
                _currentPointIndex = (_currentPointIndex + 1) % _points.Count;
            }
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent(out Player player))
            {
                DamagePopup.Create(player.transform.position + new Vector3(0.5f, 0, 0), (int)_damage);
                var health = player.gameObject.GetComponent<Health>();
                health.GetDamage(_damage);
                displayDamage();
            }
        }
    }
}

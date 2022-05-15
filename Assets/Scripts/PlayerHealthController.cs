using Attack;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerHealthController : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Transform _homePoint;
        [SerializeField] private GameObject _homeUI;

        private Health _health;

        private void Start()
        {
            _health = _player.gameObject.GetComponent<Health>();
            _health.OnHealthChanged += Die;
        }
        
        private void Die(float health)
        {
            if (health <= 0)
            {
                _homeUI.SetActive(true);
                _player.transform.position = _homePoint.position;
                GameState.ChangeState(PlayerState.InHome);
            }
        }
    }
}
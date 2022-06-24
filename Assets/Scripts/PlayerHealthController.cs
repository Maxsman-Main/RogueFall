using Attack;
using PlayerStats;
using TMPro;
using UI;
using UnityEngine;
using System.Collections;

namespace DefaultNamespace
{
    public class PlayerHealthController : MonoBehaviour
    {
        [SerializeField] private GameObject _deathMessage;
        [SerializeField] private Player _player;
        [SerializeField] private Transform _homePoint;
        [SerializeField] private GameObject _homeUI;
        [SerializeField] private LevelMaker _maker;
        [SerializeField] private MenuPanel _panelController;
        
        private Health _health;
        private PlayerParameters _parameters;
        
        private void Awake()
        {
            _health = _player.GetComponent<Health>();
            _parameters = _player.Parameters;
        }

        private void Update()
        {
            Die(_health.Value);
        }

        private void Die(float health)
        {
            if (health <= 0)
            {
                _player.transform.position = _homePoint.position;
                GameState.ChangeState(PlayerState.InHome);
                _health.SetHealth(_parameters.Items[0]);
                _homeUI.SetActive(true);
                _maker.DestroyLevel();
                _panelController.MainMenu();
                StartCoroutine(ShowDeathMessage());
            }
        }

        private IEnumerator ShowDeathMessage()
        {
            _deathMessage.SetActive(true);
            yield return new WaitForSeconds(2);
            _deathMessage.SetActive(false);
        }
    }
}
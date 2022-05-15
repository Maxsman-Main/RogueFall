using DefaultNamespace;
using UnityEngine;

namespace UI
{
    public class StartRunButton : MonoBehaviour
    {
        [SerializeField] private Transform _startPosition;
        [SerializeField] private Player _player;
        [SerializeField] private GameObject _homeUI;

        public void TranslatePlayer()
        {
            GameState.ChangeState(PlayerState.InRun);
            _homeUI.SetActive(false);
            _player.transform.position = _startPosition.position;
        }
    }
}
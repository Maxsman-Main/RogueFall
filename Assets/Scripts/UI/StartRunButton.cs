using DefaultNamespace;
using UnityEngine;

namespace UI
{
    public class StartRunButton : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private GameObject _homeUI;
        [SerializeField] private LevelMaker _maker;

        private Transform _startPosition;

        public void TranslatePlayer()
        {
            GameState.ChangeState(PlayerState.InRun);
            _homeUI.SetActive(false);
            _startPosition = _maker.Level.StartPosition;
            _player.transform.position = _startPosition.position;
        }
    }
}
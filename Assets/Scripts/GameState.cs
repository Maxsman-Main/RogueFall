using UnityEngine;

namespace DefaultNamespace
{
    public enum PlayerState
    {
        InRun,
        InHome
    }
    
    public static class GameState
    {
        [SerializeField] private static PlayerState _state = PlayerState.InHome;

        public static PlayerState State => _state;

        public static void ChangeState(PlayerState state)
        {
            _state = state;
        }
    }
}
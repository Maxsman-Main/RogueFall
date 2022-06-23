using DefaultNamespace;
using UnityEngine;

namespace Attack
{
    public class AttackInputHandler : MonoBehaviour
    {
        [SerializeField] private AttackActor _attackActor;

        private void Update()
        {
            if (GameState.State == PlayerState.InRun)
            {
                if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.Z))
                {
                    _attackActor.Attack();
                }
            }
        }
    }
}
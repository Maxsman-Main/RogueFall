using UnityEngine;

namespace Attack
{
    public class AttackInputHandler : MonoBehaviour
    {
        [SerializeField] private AttackActor _attackActor;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                _attackActor.Attack();
            }
        }
    }
}
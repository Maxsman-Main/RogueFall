using DefaultNamespace;
using UnityEngine;

namespace Move
{
    public class MoveInputHandler : MonoBehaviour
    {
        [SerializeField] private MovableActor _movableActor;
        [SerializeField] private JumpingActor _jumpingActor;

        private Mover _mover;
        private Jumper _jumper;

        private void Start()
        {
            _mover = new Mover();
            _jumper = new Jumper();
        }

        private void FixedUpdate()
        {
            if (GameState.State == PlayerState.InRun)
            {
                if (Input.GetKey(KeyCode.D))
                {
                    _mover.Move(Direction.Right, _movableActor);
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    _mover.Move(Direction.Left, _movableActor);
                }

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    _jumper.Jump(_jumpingActor);
                }
            }
        }
    }
}
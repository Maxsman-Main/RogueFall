using System;
using DefaultNamespace;
using UnityEngine;

namespace Move
{
    public class MoveInputHandler : MonoBehaviour
    {
        [SerializeField] private MovableActor _movableActor;
        [SerializeField] private JumpingActor _jumpingActor;
        public Animator animator;

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
                animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    _mover.Move(Direction.Right, _movableActor);
                }
                else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    _mover.Move(Direction.Left, _movableActor);
                }
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftShift))
            {
                _jumper.Jump(_jumpingActor);
                animator.SetBool("IsJumping", _jumpingActor.IsGrounded);
            }
        }
    }
}
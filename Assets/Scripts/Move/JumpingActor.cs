using UnityEngine;

namespace Move
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class JumpingActor : MonoBehaviour
    {
        [SerializeField] private float _jumpForce;

        private bool _isGrounded = true;

        public float JumpForce => _jumpForce;
        public Rigidbody2D RigidBody => GetComponent<Rigidbody2D>();
        public bool IsGrounded => _isGrounded;

        public void ChangeGroundedStatus(bool status)
        {
            _isGrounded = status;
        }
    
        private void OnCollisionEnter2D(Collision2D col)
        {
            if (!col.gameObject.TryGetComponent(out Player player))
            {
                _isGrounded = true;
            }
        }
    }
}
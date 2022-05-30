using UnityEngine;

namespace Move
{
    public class Jumper
    {
        public void Jump(JumpingActor jumpingActor)
        {
            if (!jumpingActor.IsGrounded) return;
            jumpingActor.RigidBody.AddForce(Vector2.up * jumpingActor.JumpForce, ForceMode2D.Impulse);
            jumpingActor.ChangeGroundedStatus(false);
        }
    }
}
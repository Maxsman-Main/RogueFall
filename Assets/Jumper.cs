using UnityEngine;

public class Jumper
{
    public void Jump(JumpingActor jumpingActor)
    {
        if (!jumpingActor.IsGrounded) return;
        
        jumpingActor.ChangeGroundedStatus(false);
        jumpingActor.RigidBody.AddForce(Vector2.up * jumpingActor.JumpForce, ForceMode2D.Impulse);
    }
}
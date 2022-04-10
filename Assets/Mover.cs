using UnityEngine;

public enum Direction
{
    Left,
    Right,
    Stop
}

public class Mover
{
    public void Move(Direction direction, MovableActor actor)
    {
        Vector2 moveVector = MakeMoveVector(direction, actor.Speed);
        actor.transform.Translate(moveVector * Time.fixedDeltaTime);
    }

    private Vector2 MakeMoveVector(Direction direction, float speed)
    {
        if (direction == Direction.Left)
        {
            return new Vector2(-speed, 0);
        }
        else if (direction == Direction.Right)
        {
            return new Vector2(speed, 0);
        }

        return Vector2.zero;
    }
    
}

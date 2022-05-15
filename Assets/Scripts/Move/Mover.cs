using UnityEngine;

namespace Move
{
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
            actor.transform.localScale = Rotate(direction);
        }

        private Vector2 MakeMoveVector(Direction direction, float speed)
        {
            if (direction == Direction.Left)
            {
                return new Vector2(-speed, 0);
            }

            if (direction == Direction.Right)
            {
                return new Vector2(speed, 0);
            }

            return Vector2.zero;
        }

        private Vector3 Rotate(Direction direction)
        {
            if (direction == Direction.Left)
            {
                return new Vector3(-1, 1, 1);
            }

            if (direction == Direction.Right)
            {
                return new Vector3(1, 1, 1);
            }

            return new Vector3(1, 1, 1);
        }
    }
}
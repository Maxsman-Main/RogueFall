using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    private State _state;

    private void Start()
    {
        if (_state != null)
        {
            _state.Entry();
        }
    }

    private void Update()
    {
        if (_state != null)
        {
            _state.Update();
        }
    }

    public void ChangeState(State state)
    {
        if (_state != null)
        {
            _state.Exit();
        }

        _state = state;
        _state.Entry();
    }
}
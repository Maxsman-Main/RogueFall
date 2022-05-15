using UnityEngine;

namespace UI
{
    public class WindowControllerButton : MonoBehaviour
    {
        [SerializeField] private Window _window;

        public void UpdateWindow()
        {
            _window.gameObject.SetActive(!_window.gameObject.activeSelf);
        }
    }
}
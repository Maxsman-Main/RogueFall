using UnityEngine;

namespace UI
{
    public class WindowControllerButton : MonoBehaviour
    {
        [SerializeField] private Window _window;
        [SerializeField] private Window _currentWindow;

        public void UpdateWindow()
        {
            _window.gameObject.SetActive(!_window.gameObject.activeSelf);
            CloseCurrentWindow();
        }

        private void CloseCurrentWindow()
        {
            _currentWindow.gameObject.SetActive(false);
        }
    }
}
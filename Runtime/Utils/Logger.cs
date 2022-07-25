using UnityEngine;

namespace SteveJstone
{
    public class Logger<T> where T : class
    {
        private bool _enabled;

        public Logger(bool enabled)
        {
            _enabled = enabled;
        }

        public void Info(string message)
        {
            if (_enabled) Debug.Log($"{typeof(T).Name}: {message}");
        }
    }
}
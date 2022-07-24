using System;

namespace SteveJstone
{
    public class ListSync
    {
        private int _currentCount;
        private Action<int> _onCreate;
        private Action<int> _onUpdate;
        private Action<int> _onDelete;

        public ListSync(int currentCount, Action<int> onCreate, Action<int> onUpdate, Action<int> onDelete)
        {
            _currentCount = currentCount;
            _onCreate = onCreate;
            _onUpdate = onUpdate;
            _onDelete = onDelete;
        }

        public void Update(int targetCount)
        {
            for (int i = 0; i < targetCount; i++)
            {
                if (_currentCount <= i)
                {
                    _onCreate(i);
                }
                _onUpdate(i);
            }

            for (int i = _currentCount - 1; i >= targetCount; i--)
            {
                _onDelete(i);
            }

            _currentCount = targetCount;
        }
    }
}
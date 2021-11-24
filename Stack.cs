using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Stack
    {
        private List<string> _stackString = new();

        public delegate void Message(string message);

        public event Message Notify;

        public List<string> Show()
        {
            return _stackString;
        }

        public string Push(string item)
        {
            _stackString.Add(item);

            Notify?.Invoke($"Элемент добавлен");

            return item;
        }

        public string Pop()
        {
            if (_stackString == null || _stackString.Count == 0)
            {
                return null;
            }
            else
            {
                var last = _stackString.LastOrDefault();
                _stackString.Remove(last);

                Notify?.Invoke($"Элемент {last} удален");

                return last;
            }
        }
    }
}





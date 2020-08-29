using System;
using System.Collections.Generic;

namespace BM.Queue
{
    public class IntegerQueue
    {
        private List<int> _integerList;
        public IntegerQueue()
        {
            _integerList = new List<int>();
        }

        public Boolean IsEmpty()
        {
            return _integerList.Count == 0;
        }

        public void EnQueue(int integer)
        {
            _integerList.Add(integer);
        }

        public int GetSize()
        {
            return _integerList.Count;
        }

        public int DeQueue()
        {
            _CheckIfQueueIsEmpty();

            int result = _integerList[0];
            _integerList.RemoveAt(0);
            return result;
        }

        public double Peek()
        {
            _CheckIfQueueIsEmpty();
            return _integerList[0];
        }

        private void _CheckIfQueueIsEmpty()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't execute operation on empty Queue!");
            }
        }
    }
}
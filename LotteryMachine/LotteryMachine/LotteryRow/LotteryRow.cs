using System;
using System.Collections.Generic;

namespace LotteryMachine
{
    public abstract class LotteryRow
    {
        protected abstract int NumbersCount { get; }
        protected abstract int AdditionalNumbersCount { get; }
        protected abstract int NumberArea { get; }
        protected abstract int AdditionalNumberArea { get; }

        public int[] Numbers { get; private set; }
        public int[] AdditionalNumbers { get; private set; }

        public LotteryRow()
        {
            Populate();
        }

        /// <summary>
        /// Initializes Numbers and AdditionalNumbers arrays and populates them.
        /// </summary>
        protected virtual void Populate()
        {
            Numbers = new int[NumbersCount];
            AdditionalNumbers = new int[AdditionalNumbersCount];

            // Fill numbers
            List<int> numberPool = new List<int>();
            FillNumberPool(numberPool, NumberArea);
            PopulateArray(Numbers, numberPool);

            // Fill additional numbers
            FillNumberPool(numberPool, AdditionalNumberArea);
            PopulateArray(AdditionalNumbers, numberPool);

        }

        /// <summary>
        /// Populate given int array with unique random numbers selected from number pool. Recursive method.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="numberPool"></param>
        /// <param name="index"></param>
        void PopulateArray(int[] array, List<int> numberPool, int index = 0)
        {
            if (index >= array.Length)
            {
                Array.Sort(array);
                return;
            }
            else if (index < 0)
                return;
            array[index] = Pop(numberPool, Factory.random.Next(numberPool.Count));
            PopulateArray(array, numberPool, ++index);
        }

        /// <summary>
        /// Pop-out value from list
        /// </summary>
        /// <param name="list"></param>
        /// <param name="index">from which index to remove.</param>
        /// <returns></returns>
        int Pop(List<int> list, int index = 0)
        {
            if (index < 0 || index >= list.Count) return 0;
            int popped = list[index];
            list.RemoveAt(index);
            return popped;
        }

        /// <summary>
        /// Clears list and populates it with numbers from 1 to numberArea
        /// </summary>
        /// <param name="list"></param>
        /// <param name="numberArea"></param>
        void FillNumberPool(List<int> list, int numberArea)
        {
            list.Clear();
            for (int i = 1; i <= numberArea; i++)
                list.Add(i);
        }
    }
}

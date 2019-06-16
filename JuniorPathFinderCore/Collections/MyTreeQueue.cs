using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPathFinderCore.Collections
{
    class MyTreeQueue<T> : IEnumerable
    {
        private List<T> items = new List<T>();
        private IComparer<T> comparer;
        public int Count => items.Count;

        public MyTreeQueue(IComparer<T> comparer)
        {
            this.comparer = comparer;
        }


        public T Peek()
        {
            return Count > 0 ? items[0] : default(T);
        }

        public void Push(T item)
        {
            items.Add(item); // Далее необходимо отбалансировать дерево
            var currentIndex = Count - 1;  // Индекс нового добавленного элемента
            int parentIndex = GetParentIndex(currentIndex); //Индекс его родительского узла
            // Балансировка. Цикл "поднятия узла, пока он меньше родителя "
            while (currentIndex > 0 && comparer.Compare(items[parentIndex],items[currentIndex]) > 0)
            {
                Swap(currentIndex, parentIndex); //Меняем элементы
                currentIndex = parentIndex;     //Новые значения индексов
                parentIndex = GetParentIndex(currentIndex);
            }
        }

        public T Pop()
        {
            if (Count == 0)
                return default(T);
            T res = items[0];
            items[0] = items[Count - 1];    // Переносим последний элемент в корень
            items.RemoveAt(Count - 1);
            Sort(0);         // Балансируем дерево
            return res;
        }
        private void Sort(int currentIndex)
        {
            int leftIndex, rightIndex, minIndex;

            while (currentIndex < Count)
            {
                minIndex = currentIndex;
                leftIndex = 2 * currentIndex + 1;   // Вычисляем индексы дочерних узлов
                rightIndex = 2 * currentIndex + 2;
                // ищем минимальный узел из дочерних, но при этом меньше родительского (кандидат на обмен)
                if (leftIndex < items.Count && comparer.Compare(items[currentIndex],items[leftIndex]) > 0)  // Если левый меньше корневого отмечаем его как минимальный
                {
                    minIndex = leftIndex;
                }
                if (rightIndex < items.Count && comparer.Compare(items[minIndex],items[rightIndex]) > 0)    // Сравниваем правый узел с текущим минимальным 
                {
                    minIndex = rightIndex;
                }
                if (currentIndex == minIndex)   // минимальный индекс не поменялся, значит баланс, прерываем работу 
                    break;
                Swap(currentIndex, minIndex);   // Меняем текущий индекс на минимальный
                currentIndex = minIndex;
            }
        }

        private void Swap(int currentIndex, int parentIndex)
        {
            T temp = items[currentIndex];
            items[currentIndex] = items[parentIndex];
            items[parentIndex] = temp;
        }
        private int GetParentIndex(int currentIndex)    // Возвращает индекс родителя по индексу элемента
        {
            return (currentIndex - 1) / 2;
        }

        public IEnumerator GetEnumerator()
        {
            while (Count > 0)
            {
                yield return Pop();
            }
        }


    }
}

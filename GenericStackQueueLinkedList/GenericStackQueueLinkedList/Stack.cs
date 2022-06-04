namespace GenericStackQueueLinkedList
{
    public class MyStack<T>
    {
        LinkedList<T> newLinkedList = new LinkedList<T>();
        public int Count
        {
            get
            {
                return newLinkedList.Count;
            }
        }
        public bool Get(T item)
        {
            return newLinkedList.Contains(item);
        }
        public bool IsEmpty()
        {
            return newLinkedList.Count == 0 ? true : false;
        }

        public void Push(T item)
        {
            newLinkedList.AddLast(item);
        }

        public T Pop()
        {
            var list = newLinkedList.ToList();
            T lastValue = list[newLinkedList.Count - 1];

            newLinkedList.RemoveLast();

            return lastValue;
        }

        public T Peek()
        {
            var list = newLinkedList.ToList();
            T lastValue = list[newLinkedList.Count - 1];

            return lastValue;
        }

        public int Size()
        {
            return newLinkedList.Count;
        }

        public void Display()
        {
            foreach (var item in newLinkedList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}

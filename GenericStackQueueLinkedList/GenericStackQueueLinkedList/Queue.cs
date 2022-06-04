namespace GenericStackQueueLinkedList
{
    public class MyQueue<T>
    {
        LinkedList<T> newLinkedList = new LinkedList<T>();
        public int Count
        {
            get
            {
                return newLinkedList.Count;
            }
        }
        public bool IsEmpty()
        {
            return newLinkedList.Count == 0 ? true : false;
        }

        public void Enqueue(T item)
        {
            newLinkedList.AddLast(item);
        }

        public T Dequeue()
        {
            var list = newLinkedList.ToList();

            newLinkedList.RemoveFirst();

            return list[0];
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

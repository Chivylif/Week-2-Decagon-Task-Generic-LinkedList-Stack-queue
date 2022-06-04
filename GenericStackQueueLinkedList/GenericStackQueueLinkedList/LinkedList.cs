
namespace GenericStackQueueLinkedList
{

    public class Node<T>
    {
        public T data;
        public Node<T>? next;

        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
    public class MyLinkedList<T>
    {
        public Node<T>? head = null;
        public int Count { get; set; }

        public int AddToFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.next = head;
            head = node;
            Count++;

            return Count;
        }
        public int Add(T data)
        {
            Node<T>? node = new Node<T>(data);
            node.next = null;

            if (head == null)
            {
                node.next = head;
                head = node;

                Count++;
                return Count;
            }
            //Transverse through the list
            Node<T>? current = head;

            while (current?.next != null)
            {
                current = current.next;
            }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            current.next = node;
#pragma warning restore CS8602 // Dereference of a possibly null reference.


            Count++;
            return Count;
        }

        public bool Remove(T item)
        {
            Node<T>? current = head;
            Node<T>? previous = null;

            if (current != null && Equals(current.data, item))
            {
                head = current.next;
                return true;
            }

            while (current != null)
            {
                if (Equals(current.data, item))
                {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    previous.next = current.next;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    Count--;
                    return true;
                }

                previous = current;
                current = current.next;
            }

            return false;
        }

        public bool Check(T item)
        {
            Node<T>? current = head;

            while (current != null)
            {
                if (Equals(current.data, item))
                {
                    return true;
                }

                current = current.next;
            }

            return false;
        }
        public void Display()
        {
            Node<T>? current = head;

            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }

            Console.WriteLine();
        }

        public int Index(int item)
        {
            int index = 0;
            Node<T>? current = head;

            while (current != null)
            {
                if (Equals(current.data, item))
                {
                    return index;
                }

                current = current.next;
                index++;
            }

            return -1;
        }
    }
}

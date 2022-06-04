var stack = new GenericStackQueueLinkedList.MyStack<int>();
var queue = new GenericStackQueueLinkedList.MyQueue<int>();
var linkedList = new GenericStackQueueLinkedList.MyLinkedList<int>();

//LinkedList Operations
linkedList.AddToFirst(1);
linkedList.AddToFirst(2);
linkedList.AddToFirst(3);
linkedList.AddToFirst(4);
linkedList.AddToFirst(5);

Console.WriteLine("*********All the elements in the Linked List before adding to the tail:**********");
linkedList.Display();

linkedList.Add(6);
Console.WriteLine("*********All the elements in the Linked List after adding one element to the front:**********");
linkedList.Display();

var index = linkedList.Index(4);
Console.WriteLine("*********The index of 4 in the Linked List:**********");
Console.WriteLine(index);

var removed = linkedList.Remove(2);
Console.WriteLine("*********All the elements in the Linked List after removing 2:**********");
linkedList.Display();

var num = linkedList.Count;
Console.WriteLine("*********The count of all the elements in the Linked List:**********");
Console.WriteLine(num);

//Stack Operations
stack.Push(1);
stack.Push(2);
stack.Push(3);

Console.WriteLine("*********All the elements in the Stack before popping:**********");
stack.Display();

stack.Pop();
Console.WriteLine("*********All the elements in the Stack after popping:**********");
stack.Display();

stack.Push(4);
stack.Push(5);

//Display the elements of the stack
Console.WriteLine("*********All the elements in the Stack after adding 4 and 5:**********");
stack.Display();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

//Display all the elements in the queue
Console.WriteLine("*********All the elements in the queue before dequeuing:**********");
queue.Display();

queue.Dequeue();
Console.WriteLine("*********All the elements in the queue after dequeuing:**********");
queue.Display();


using DataStructureProblem;

LinkedLists linkedLists = new LinkedLists();

Stack stack = new Stack();
Queue queue = new Queue();
Node nodeA = new Node(56);
Node nodeB = new Node(30);
Node nodeC = new Node(70);

queue.Enqueue(56);
queue.Enqueue(30);
queue.Enqueue(70);
queue.DisplayQueue();
queue.Top();

queue.Dequeue();
queue.DisplayQueue();
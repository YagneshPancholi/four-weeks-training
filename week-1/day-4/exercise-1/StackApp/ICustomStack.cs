namespace StackApp
{
    internal interface ICustomStack<T>
    {
        void Push(T item);
        T Pop();
        bool IsEmpty();
    }
    public class Stack<T> :ICustomStack<T>
    {
        StackNode? root;
        public class StackNode{
            public T data;
            public StackNode? next;
            public StackNode(T data){
                this.data = data;
            }
        }
        public void Push(T data)
        {
            StackNode newNode = new StackNode(data);
            if(root == null){
                root = newNode;
            }else{
                StackNode temp = root;
                root = newNode;
                newNode.next = temp;
            }
            Console.WriteLine(data + " pushed to stack!!");
        }
        public T Pop()
        {
            if(IsEmpty()){
                Console.WriteLine("oops Stack is empty!!");
                return default;
            }else{
                T poppedData = root.data;
                root = root.next;
                Console.WriteLine(poppedData + " popped!!");
                return poppedData;
            }
        }
        public bool IsEmpty()
        {
            if(root == null){
                return true;
            }else{
                return false;
            }
        }
    }
}

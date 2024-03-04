using System;



public class Queue<T>  {


    public class Node{

        public T? Value;
        public Node? Next;

        public Node(T value){
            Value = value;
            Next = null;
        }
    }

    protected Node? head;
    protected Node? tail;
    int count;


    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }



    public void Enqueue(T value){

        Node newNode = new Node(value);
    
        if(head == null){
            head = newNode;
            tail = newNode;
        }else{
            tail!.Next = newNode;
            tail = newNode;
        }
         count++;
    }


    public T? Dequeue(){

        T? CurrentValue;

        if(count == 0){
            Console.WriteLine("Queue is emtpy");
            return default(T);
        }else{
            count--;

            CurrentValue = head!.Value;
            head = head.Next;
        }

          return CurrentValue;
    }
    


    public Type CheckType(){
        return typeof(T);
    }

    public int Count(){
        return count;
    }
    
}
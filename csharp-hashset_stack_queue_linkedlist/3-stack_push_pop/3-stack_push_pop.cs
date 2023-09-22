using System.Collections;

class MyStack{

    public static Stack<string> Info(Stack<string> aStack, string newItem, string search){
        Console.WriteLine($"Number of items: {aStack.Count}");

        if(aStack.Count == 0){
            Console.WriteLine("Stack is empty");
        }else{
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }

        if(aStack.Contains(search)){
            Console.WriteLine($"Stack contains \"{search}\" : True");
        }else{
            Console.WriteLine($"Stack contains \"{search}\" : False");
        }

        for(int i = 0; i <= aStack.Count; i++){
            if(aStack.Contains(search)){
                string temp = aStack.Pop();
            }
        }

        aStack.Push(newItem);

        return aStack;
    }
}
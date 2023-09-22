using System.Collections;

class LList{
    public static LinkedList<int> CreatePrint(int size){
        LinkedList<int> newList = new LinkedList<int>();
        if(size < 0){
            return newList;
        }else{
            for(int i = 0; i < size; i++){
                Console.WriteLine(i + "");
                newList.AddFirst(i);
            }
        }
        return newList;
    }
}
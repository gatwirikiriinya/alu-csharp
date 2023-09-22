using System.Collections.Generic;

class LList{
    public static void Delete(LinkedList<int> myLList, int index){
        int totalcount = 0;
        LinkedListNode<int> current;
        current = myLList.First;

        while(current != null){
            if(totalcount == index){
                myLList.Remove(current);
            }
            current = current.Next;
            totalcount++;
        }
    }
}
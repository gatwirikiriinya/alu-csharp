using System.Collections.Generic;

class LList{
    public static int GetNode(LinkedList<int> myLList, int n){
        int index = 0;
        foreach(int integer in myLList){
            if(index == n){
                return integer;
            }
            index++;
        }

        return 0;
    }
}
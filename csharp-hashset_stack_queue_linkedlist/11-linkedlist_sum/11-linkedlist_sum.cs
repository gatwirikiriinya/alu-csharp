using System.Collections.Generic;


class LList{

    public static int Sum(LinkedList<int> myLList){
        int totalsum = 0;
        foreach(int value in myLList){
            totalsum += value;
        }
        return totalsum;
    }
}
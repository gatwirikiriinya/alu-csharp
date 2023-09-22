using System.Collections;

class LList{

    public static int Length(LinkedList<int> myList){
        int totalcount = 0;
        foreach(int value in myList){
            totalcount++;
        }
        return totalcount;
    }
}
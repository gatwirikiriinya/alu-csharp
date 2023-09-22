using System.Collections;

class List{

     static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() {1, 2, 3, 4, 5, 6};
        List<int> myList2 = new List<int>() {0, 2, 4, 6, 7, 8};
        List<int> different;

        different = List.DifferentElements(myList1, myList2);

        foreach (int i in different)
            Console.WriteLine(i);
    }
    public static List<int> DifferentElements(List<int> list1, List<int> list2){
        HashSet<int> uniqueElements1 = new HashSet<int>(list1);
        HashSet<int> uniqueElements2 = new HashSet<int>(list2);

        uniqueElements1.SymmetricExceptWith(uniqueElements2);
        int[] arrayintegers;
        arrayintegers = uniqueElements1.ToArray();
        Array.Sort(arrayintegers);
        uniqueElements1.Clear();
        uniqueElements1.UnionWith(arrayintegers);

        return new List<int>(uniqueElements1);
    }
}
using System.Collections;

class List{

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
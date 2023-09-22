using System.Collections;

class List{

    public static List<int> CommonElements(List<int> list1, List<int> list2){
        HashSet<int> uniqueHash = new HashSet<int>(list1);
        HashSet<int> commonHash = new HashSet<int>(list2);

        commonHash.IntersectWith(uniqueHash);
        List<int> commonElements = new List<int>(commonHash);

        return commonElements;
    }
}
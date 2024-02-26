namespace csharp_codes;
public class ArrayClass
{
    public static int[] intArray(int size){
        return new int[size];
    }

    public static void dynamicArr(int size){
        int [] dynamic = new int[size];
        for (int i = 0; i < size; i++)
        {
            dynamic[i] = i;
        }
        for (int i = 0; i < size; i++)
        {
            System.Console.WriteLine(dynamic[i]);
        }

        dynamic = new int[20];
        for (int i = 0; i < dynamic.Length; i++)
        {
            dynamic[i] = i + (i-1);
        }
        for (int i = 0; i < dynamic.Length; i++)
        {
            System.Console.WriteLine(dynamic[i]);
        }
    }
}

namespace csharp_codes;
public class RemoveEvans
{
    public static void RemoveEvansFromArr(int[] arr, int size){
        int m =0;
        for (int i = 0; i < size; i++)
        {
            if(arr[i]%2!=0){
                arr[m] = arr[i];
                ++m;
            }   
        }

        int[] temp = new int[m];
        for (int i = 0; i < m; i++)
        {       
            temp[i] = arr[i];
            System.Console.WriteLine(arr[i]);
        }
    }

    public static void RemoveEvansFromArrV2(int[] arr, int size){
        // 0, 1 ,2 ,3, 4, 5, 6, 7, 8, 9}, 10
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write( arr[i]+" ");
        }
        int i1 = 0;
        int j1 = 0;

        while(j1<arr.Length){
            if(arr[j1] %2 !=0){ // odd values 
                // replace with i1 index 
                arr[i1] = arr[j1];
                i1++;
            }
            j1++;
        }
        System.Console.WriteLine(" After remove evens");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write( arr[i]+" ");
        }

    }
}

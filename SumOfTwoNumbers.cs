namespace csharp_codes;
public class SumOfTwoNumbers
{
    public static int[] FindSumOfTwoNumber(int[] arr, int sum){
        HashSet<int> seen = new HashSet<int>();
        int[] result = new int[2];
        
        for (int i = 0; i < arr.Length; i++)
        {
            int item = arr[i];
            int targetNum = sum - item;
            seen.Add(item);
            if(seen.Contains(targetNum)){
                return new int[2]{item, targetNum};
            }
        }

        return result;
    }

    public static int[] FindSumOfTwoNumberBySort(int[] arr, int target){
        int[] result = new int[2];
        Array.Sort(arr);
        int start = 0;
        int end = arr.Length -1;
        while(start < end){
            int sum = arr[start] + arr[end];
            if(sum < target){
                start++;
            }else if(sum > target){
                end--;
            }else {
                result[0] = arr[start];
                result[1] = arr[end];
                return result;
            }
        }

        return result;
    }
}

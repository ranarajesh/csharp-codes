namespace csharp_codes;
public class MergeSortedArrays
{
    public static int[] mergeArrays(int[] arr1, int[] arr2){
        int arr1Len = arr1.Length;
        int arr2Len = arr2.Length;
        int i=0, j=0, k=0;

        int [] sortedArr = new int[arr1Len + arr2Len];

        while(i<arr1Len && j<arr2Len){
            if(arr1[i]< arr2[j]){
                sortedArr[k++] = arr1[i++];
            }else{
                sortedArr[k++] = arr2[j++];
            }
        }
        while(i < arr1Len){
              sortedArr[k++] = arr1[i++];
        }
        while(j < arr2Len){
              sortedArr[k++] = arr2[j++];
        }
        return sortedArr;
    }
}

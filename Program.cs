// See https://aka.ms/new-console-template for more information
using csharp_codes;
var arr = ArrayClass.intArray(8);
System.Console.WriteLine(arr.Length);
var mul_arr = MultiDimensionalArray.multiArr();
Console.WriteLine(mul_arr[0,1]);

ArrayClass.dynamicArr(10);
System.Console.WriteLine("***********RemoveEvans.RemoveEvansFromArr*************");
RemoveEvans.RemoveEvansFromArr(new int[]{0, 1 ,2 ,3, 4, 5, 6, 7, 8, 9}, 10);
System.Console.WriteLine("***********RemoveEvans.RemoveEvansFromArr*************");
RemoveEvans.RemoveEvansFromArrV2(new int[]{-23,1,-2,5,44,-9,8}, 10);
RemoveEvans.RemoveEvansFromArrV2(new int[]{4,-3,56,29,-39,-94,87}, 10);
System.Console.WriteLine("***********MergeSortedArrays*************");
var mergeArr = MergeSortedArrays.mergeArrays(new int[]{0, 1 ,2 ,3, 4, 5, 6, 7, 8, 9},new int[]{-23,-2, 1, 5});
for (int i = 0; i < mergeArr.Length; i++)
{
    System.Console.Write(" "+mergeArr[i]);
}
System.Console.WriteLine("***********MergeSortedArrays*************");

System.Console.WriteLine("***********Sum of Two number from array*************");
var sumofArr = SumOfTwoNumbers.FindSumOfTwoNumber(new int[]{1,21,3,14,5,60,7,6}, 81);
System.Console.WriteLine(String.Join(",", sumofArr));
sumofArr = SumOfTwoNumbers.FindSumOfTwoNumber(new int[]{1,21,3,14,5,60,7,6}, 22);
System.Console.WriteLine(String.Join(",", sumofArr));
var sumofArrBySort = SumOfTwoNumbers.FindSumOfTwoNumberBySort(new int[]{1,21,3,14,5,60,7,6}, 22);
System.Console.WriteLine(String.Join(" ", sumofArrBySort));

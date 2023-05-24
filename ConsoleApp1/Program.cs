//Дано два массива с неубывающими целыми числами. Напиши-те программу, формирующую новый массив из элементов первых двух. В результирующем массиве недолжно быть одинаковых элементов.
//19 вариант

int[] array1 = { 1, 3, 5, 7, 9 };
int[] array2 = { 2, 4, 6, 8, 10 };

int[] resultArray = array1.Union(array2).ToArray(); 

foreach (int element in resultArray)
{
    Console.Write(element + " "); 
}
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

class App
{
    public static void Main(string[] args)
    {
        int[] array = { 10, 5, 1, 4, 9, 8, 1, 5, 1 };
        MergeSortInPLace.Sort(array);
        array.ToList().ForEach(x => Console.Write(x + " "));

        Console.WriteLine();

        string[] HexNumbers = { "AF3", "12D", "236", "120", "011", "001", "0A1" };
        StringHexPositionSort stringHexPositionSort = new StringHexPositionSort();
        stringHexPositionSort.Sort(HexNumbers, 3);
        HexNumbers.ToList().ForEach(x => Console.Write(x + " "));

        //int a = 5;
        //  int b = 6;
        // Console.WriteLine($"{a} {b}");
        //  (a, b) = (b, a);
        // Console.WriteLine($"{a} {b}");

    }
}

//Cwiczenie 2
//Zaimplementuj metodę wykonującą scalanie w miejscu
//4 punkty
public class MergeSortInPLace
{
    public static void Sort(int[] arr)
    {
        SortArray(arr, 0, arr.Length - 1);
    }
    private static void SortArray(int[] arr, int left, int right)
    {
        if (left == right)
        {
            return;
        }
        if (left + 1 == right)
        {
            if (arr[left] > arr[right])
            {
                (arr[left], arr[right]) = (arr[right], arr[left]); //zamien dwa elementy tablicy miejscami
            }
        }
        var mid = (left + right) / 2;
        SortArray(arr, left, mid);
        SortArray(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }
    //zaimplementuj tę metodę, tak, aby wykonać scalanie w miejscu
    //left  - indeks pierwszego elementu pierwszej podtablicy
    //mid   - indeks ostatniego elementu pierwszej podtablicy
    //right - indeks ostatniego elementu drugiej podtablicy
    //Przykład
    //arr   => {2, 4, 6, 3, 5, 8, 11, 7}
    //left  => 0
    //mid   => 2
    //right => 5
    //po wykonaniu scalania tablica arr powinna mieć postać:
    //arr => {2, 3, 4, 5, 6, 8, 11, 7}
    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int leftSize = mid - left + 1;
        int rightSize = right - mid;
        int[] leftArr = new int[leftSize];
        int[] rightArr = new int[rightSize];

        for (int x = 0; x < leftSize; x++)
        {
            leftArr[x] = arr[left + x];
        }
        for (int x = 0; x < rightSize; x++)
        {
            rightArr[x] = arr[mid + 1 + x];
        }


        int i = 0, j = 0, k = left;
        while (i < leftSize && j < rightSize)
        {
            if (leftArr[i] <= rightArr[j])
            {
                arr[k] = leftArr[i++];
            }
            else
            {
                arr[k] = rightArr[j++];
            }
            k++;
        }

        while (i < leftSize)
        {
            arr[k++] = leftArr[i++];
        }
        while (j < rightSize)
        {
            arr[k++] = rightArr[j++];
        }
    }
}
//Cwiczenie 3
//8 punktów
//Zaimplementuj klasę do sortowania pozycyjnego liczb szesnastkowych zapisanych w łańcuchach 
//Przykładowa tablica do posortowania
//string[] HexNumbers = {"AF3", "12D", "236", "120"};
//talica po posortowania
//{"120", "12D", "236", "AF3"}

class StringHexPositionSort
{
    //Zadeklaruj tablicę kolejek dla każdej cyfry szestnastkowej
    //Każda kolejka jest typu string
    private Queue<string>[] queue = new Queue<string>[16];

    private void Init()
    {
        for (int i = 0; i < queue.Length; i++)
        {
            if (queue[i] == null)
            {
                queue[i] = new Queue<string>();
            }
            else
            {
                queue[i].Clear();
            }
        }
    }

    private void Dequeue(string[] arr)
    {
        //zaimplementuje pobieranie z kolejek łańcuchów z liczbami i umieszczanie ich w tablicy arr
        int index = 0;
        for (int i = 0; i < queue.Length; i++)
        {
            while (queue[i].Count > 0)
            {
                arr[index++] = queue[i].Dequeue();
            }
        }

    }

    //Zaimplementuj metodę, aby zwracała liczbę równą cyfrze szesnastkowej na podanej pozycji (position) w łańcuchu str
    //Pozycja jest numerowana od prawej do lewej
    // np. dla łańcucha "AB12"
    // cyfra na pozycji 0 to 2,
    // cyfra na pozycji 2 to 11,
    // cyfra na pozycji 8 to 0
    private int ExtractDigit(string str, uint position)
    {
        if (str.Length < position)
        {
            return 0;
        }
        int index = str.Length - (int)position - 1;
        if (Char.IsDigit(str[index]))
        {
            return int.Parse(str[index] + "");
        }
        else if (Char.IsUpper(str[index]))
        {
            return str[index] - 'A' + 10;
        }

        return 0;
    }

    //zaimplementuj umieszczanie liczb łacuchów z liczbami hex w kolejce odpowiadającej cyfrze na podanej pozycji
    private void Enqueue(string[] arr, uint position)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int digit = ExtractDigit(arr[i], position);
            queue[digit].Enqueue(arr[i]);
        }
    }
    //Tej metody nie zmieniaj!!!
    public void Sort(string[] arr, int d)
    {
        Init();
        for (uint position = 0; position < d; position++)
        {
            Enqueue(arr, position);
            Dequeue(arr);
        }
    }
}
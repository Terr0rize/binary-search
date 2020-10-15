using System;
using System.Runtime.InteropServices;

public class HeapSort
{
    public void sort(int[] arr)
    {
        int n = arr.Length;
       
        for (int i = n / 2 - 1; i >= 0; i--)
            heapify(arr, n, i);
      
        for (int i = n - 1; i >= 0; i--)
        {            
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
           
            heapify(arr, i, 0);
        }
    }

    void heapify(int[] arr, int n, int i)
    {
        int largest = i;       
        int l = 2 * i + 1; 
        int r = 2 * i + 2; 
     
        if (l < n && arr[l] > arr[largest])
            largest = l;

        if (r < n && arr[r] > arr[largest])
            largest = r;
      
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;
           
            heapify(arr, n, largest);
        }
    }

    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.Read();
    }

    public static void Main()
    {
        int key;
        Console.WriteLine("Введите размер массива: ");
        key = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[key];
        Console.WriteLine("Введите " + key + " " + "чисел: ");
        for (int i = 0; i < arr.Length; i++)
            arr[i] = int.Parse(Console.ReadLine());

        HeapSort anime = new HeapSort();
        Console.WriteLine("Неотсортированный массив: "); printArray(arr);
        anime.sort(arr);
        Console.WriteLine("\nОтсортированный массив: "); printArray(arr);

    }
}

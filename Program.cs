/*
Kod av Anne-Lii Hansen anha2324@student.miun.se
En konsoll app som sorterar randomiserade tal med bubblesort och med inbyggd sortering och jämför tidsskillnaden*/

using System;
using System.Diagnostics;


class Program
{

    // Metod för att skapa en array med slumpmässiga heltal
    static int[] RandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(0, 100); // Skapa tal mellan 0 och 100
        }
        return array;
    }


    static void Main(string[] args)
    {

        int[] array = RandomArray(100); //skapar en array med 100 tal
        int[] clonedForBubblesort = (int[])array.Clone();//klon av array för bubblesort
        int[] clonedForArraysort = (int[])array.Clone();//klon av array för Array.Sort

        Console.WriteLine("Osorterad array");
        Console.WriteLine(string.Join(", ", array));

        //Mäter tiden för att sortera Bubblesort
        Stopwatch stopwatch = new Stopwatch(); //nytt tidur
        stopwatch.Start(); //starta tidur
        Bubblesort(clonedForBubblesort); //anropar Bubblesort och skickar med clonad data
        stopwatch.Stop(); //stoppar tidur
        Console.WriteLine("Sorterad med Bubblesort: ");
        Console.WriteLine(string.Join(", ", clonedForBubblesort));
        Console.WriteLine($"Tid att sortera med Bubblesort: {stopwatch.ElapsedMilliseconds} ms");


        //Mäter tiden för att sortera Array.Sort
        stopwatch.Restart(); //nollställer tidur
        Array.Sort(clonedForArraysort);//sorterar clonad data med inbyggd sortering
        stopwatch.Stop(); //stoppar tidur
        Console.WriteLine("\nArray.Sort sorterad array:");
        Console.WriteLine(string.Join(", ", clonedForArraysort));
        Console.WriteLine($"Tid att sortera med Array.Sort: {stopwatch.ElapsedMilliseconds} ms");
    }
    static void Bubblesort(int[] data)
    {
        bool needsSorting = true;

        //loopa igenom alla tal som ska sorteras
        for (int i = 0; i < data.Length - 1 && needsSorting; i++)
        {
            needsSorting = false;
            for (int j = 0; j < data.Length - 1 - i; j++)
            {
                //flytta större tal framåt
                if (data[j] > data[j + 1])
                {
                    //sortera
                    needsSorting = true;
                    //Byt plats på tal
                    int temp = data[j + 1];
                    data[j + 1] = data[j];
                    data[j] = temp;
                }
            }
        }
    }


}

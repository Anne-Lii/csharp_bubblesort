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

        if (args.Length < 2 || args[0] != "-p")
        {
            Console.WriteLine("Skriv dotnet run -- -p 0 för stigande, 1 för fallande>");
            return;
        }

        bool sortDescending = args[1] == "1"; //sortera fallande om 1, annars stigande

        int[] array = RandomArray(100); //skapar en array med 100 tal
        int[] clonedForBubblesort = (int[])array.Clone();//klon av array för bubblesort
        int[] clonedForArraysort = (int[])array.Clone();//klon av array för Array.Sort

        Console.WriteLine("Osorterad array");
        Console.WriteLine(string.Join(", ", array));

        //Mäter tiden för att sortera Bubblesort
        Stopwatch stopwatch = new Stopwatch(); //nytt tidur
        stopwatch.Start(); //starta tidur
        Bubblesort(clonedForBubblesort, sortDescending); //anropar Bubblesort med vald sortering
        stopwatch.Stop(); //stoppar tidur
        Console.WriteLine("Sorterad med Bubblesort: ");
        Console.WriteLine(string.Join(", ", clonedForBubblesort));
        Console.WriteLine($"Tid att sortera med Bubblesort: {stopwatch.ElapsedMilliseconds} ms");


        //Mäter tiden för att sortera Array.Sort
        stopwatch.Restart(); //nollställer tidur
        Array.Sort(clonedForArraysort);//sorterar clonad data i stigande ordning
        if (sortDescending)
        {
            Array.Reverse(clonedForArraysort); //sorterar fallande ordning
        }
        stopwatch.Stop(); //stoppar tidur
        Console.WriteLine("\nArray.Sort sorterad array:");
        Console.WriteLine(string.Join(", ", clonedForArraysort));
        Console.WriteLine($"Tid att sortera med Array.Sort: {stopwatch.ElapsedMilliseconds} ms");
    }
    static void Bubblesort(int[] data, bool sortDescending)
    {
        bool needsSorting = true;

        //loopa igenom alla tal som ska sorteras
        for (int i = 0; i < data.Length - 1 && needsSorting; i++)
        {
            needsSorting = false;
            for (int j = 0; j < data.Length - 1 - i; j++)
            {
                 if ((sortDescending && data[j] < data[j + 1]) || (!sortDescending && data[j] > data[j + 1]))
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

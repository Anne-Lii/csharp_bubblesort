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
            array[i] = random.Next(0, 100); // Generera tal mellan 0 och 100
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
    }
    

}

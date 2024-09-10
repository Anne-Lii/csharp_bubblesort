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

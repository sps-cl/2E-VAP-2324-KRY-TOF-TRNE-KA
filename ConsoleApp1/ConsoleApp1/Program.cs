using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Write("Zadej retezec cisel s carkou");
                    Console.WriteLine();
                    string userInput= Console.ReadLine();
                    string[] znakyVyrazu= userInput.Split(',');
                    int[] cisla = new int[znakyVyrazu.Length];
                    for (int i = 0; i < znakyVyrazu.Length; i++)
                    {
                         cisla[i] = int.Parse(znakyVyrazu[i]);
                    }
                    if (cisla.Length > 0)
                    {
                        int minNumber= cisla.Min();
                        int maxNumber= cisla.Max();

                        Console.WriteLine($"Nejvetsi cislo je: {maxNumber}");
                        Console.WriteLine($"Nejmensi cislo je: {minNumber}");
                    
                    }
                    int currentInt = 1;
                    int maxInt = 1;

                    for (int i = 1; i < cisla.Length; i++)
                    {
                        if (cisla[i] > cisla[i - 1])
                        {
                            currentInt += 1;
                            if (currentInt > maxInt)
                            {
                             maxInt = currentInt;
                            }
                        }
                        else

                        {
                            currentInt = 1;
                        }
                    }

                    Console.WriteLine($"Nejdelsi interval je : {maxInt}");

                }


            }
            catch (FormatException)
            {
             Console.WriteLine("Chyba: Vstup neni platny");
             Console.ReadLine();
             while (true)
               {
                  Console.Write("Zadej retezec cisel s carkou");
                  Console.WriteLine();
                  string userInput = Console.ReadLine();
                  string[] znakyVyrazu = userInput.Split(',');
                  int[] cisla = new int[znakyVyrazu.Length];
                  for (int i = 0; i < znakyVyrazu.Length; i++)
                    {
                        cisla[i] = int.Parse(znakyVyrazu[i]);
                    }
                    if (cisla.Length > 0)
                    {
                        int minNumber = cisla.Min();
                        int maxNumber = cisla.Max();

                        Console.WriteLine($"Nejmensi cislo je: {minNumber}");
                        Console.WriteLine($"Nejvetsi cislo je: {maxNumber}");
                    }
                    int currentInt = 1;
                    int maxInt = 1;

                    for (int i = 1; i < cisla.Length; i++)
                    {
                        if (cisla[i] > cisla[i - 1])
                        {
                            currentInt += 1;
                            if (currentInt > maxInt)
                            {
                                maxInt = currentInt;
                            }
                        }
                        else
                        {
                            currentInt = 1;
                        }
                    }

                    Console.WriteLine($"Nejdelsi interval je: {maxInt}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> slovaZpet = new Stack<string>();
            Stack<string> slovaVpred = new Stack<string>();
            string aktualniSlovo = "";
            while (true)
            {
                string vstup = Console.ReadLine();

                if (vstup.StartsWith("Pridat"))
                {
                    string[] slova = vstup.Split(':');
                    if (slova.Length < 2)
                    {
                        Console.WriteLine("Neplatný vstup");
                        continue;
                    }
                    else
                    {
                        aktualniSlovo = slova[1];
                        while (slovaVpred.Count > 0)
                        {
                            slovaZpet.Push(slovaVpred.Pop());
                        }
                        slovaZpet.Push(aktualniSlovo);
                    }
                }
                else if (vstup.StartsWith("Zpet"))
                {
                    if (slovaZpet.Count > 0)
                    {
                        slovaVpred.Push(slovaZpet.Pop());
                        if (slovaZpet.Count > 0) aktualniSlovo = slovaZpet.Peek();
                    }
                }
                else if (vstup.StartsWith("Vpred"))
                {
                    if (slovaVpred.Count > 0)
                    {
                        slovaZpet.Push(slovaVpred.Pop());
                        if (slovaVpred.Count > 0) aktualniSlovo = slovaVpred.Peek();
                    }
                }
                else
                {
                    Console.WriteLine("Neznámý vstup");
                    continue;
                }
                Console.WriteLine(aktualniSlovo);
            }
        }
    }
}

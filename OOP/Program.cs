using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kontakt> kontakte = new List<Kontakt>();
            while (true)
            {


                Console.WriteLine("Wollen sie einen neuen Kontakt anlegen? (j/n)");
                string input = Console.ReadLine();

                if (input == "j")
                {
                    Kontakt k = new Kontakt();
                    Console.Write("Vorname:");
                    string firstName = Console.ReadLine();
                    Console.Write("Nachname:");
                    string lastName = Console.ReadLine();
                    Console.Write("Email:");
                    string email = Console.ReadLine();

                    k.FirstName = firstName;
                    k.LastName = lastName;
                    k.Email = email;

                    kontakte.Add(k);
                }
                else
                {
                    Console.WriteLine("Willst du zuerst mit Vor- oder Nachnamen ausgeben? [v,n]");
                    string input2 = Console.ReadLine();
                    if (input2 == "v")
                    {
                        foreach (Kontakt k in kontakte)
                        {
                            Console.WriteLine(k.FirstName + "," + k.LastName + "(" + k.Email + ")");
                        }
                    }
                    else
                    {
                        foreach (Kontakt k in kontakte)
                        {
                            Console.WriteLine(k.LastName + "," + k.FirstName + "(" + k.Email + ")");
                        }
                    }

                }
            }
        }
    }
}

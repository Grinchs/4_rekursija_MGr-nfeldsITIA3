using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_rekursija_MGrīnfeldsITIA3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet skaitli:");
            int number = int.Parse(Console.ReadLine());
            int sum = Summa(number);
            Console.WriteLine($"Ciparu summa ir: {sum}");
        }

        static int Summa(int number)
        {
            // Ja skaitlis ir vienaciparu, atgriežam to
            if (number < 10)
            {
                return number;
            }
            // Atgriežam pēdējo ciparu plus atkārtoti izsauktu funkciju ar atlikušo skaitli
            return number % 10 + Summa(number / 10);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculatorMachine;

namespace CalculatorConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Demo Unit Menggunakan Console App";
            Calculator cal = new Calculator();

            Console.WriteLine("Hasil Penambahan 2 + 3 = {0}", cal.Penambahan(2, 3));
            Console.WriteLine("Hasil Pengurangan 7 - 3 = {0}", cal.Pengurangan(7, 3));
            Console.WriteLine("Hasil Perkalian 5 x 2 = {0}", cal.Perkalian(5, 2));
            Console.WriteLine("Hasil Pembagian 6 : 2 = {0}", cal.Pembagian(6, 2));

            Console.ReadKey();
        }
    }
}

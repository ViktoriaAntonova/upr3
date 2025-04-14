using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RequestMenager r = new RequestMenager();
            Console.WriteLine("Vuvedete broq zaqvki: ");
            int n = int.Parse(Console.ReadLine());
            bool isValid = false;
            while (!isValid)
            {
                if (n < 1 || n > 1000)
                {
                    Console.WriteLine("Vuvedete chislo ot 1 do 1000");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"Oceka se da vavedete {n} zaqvki.");
                }
            }
            for (int i = 0; i < n; i++)
            {
                string requestName = Console.ReadLine();
                FileRequest request = new FileRequest(requestName);
                r.Add(request);
            }
            Console.WriteLine("Zaqvkite sa:");
            r.PrintRequests();
        }
    }
}

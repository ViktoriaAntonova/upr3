using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Stack<string>> d = new Dictionary<string, Stack<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                string command = parts[0].ToUpper();
                if (command == "EXIT")
                {
                    Console.WriteLine("Програмата приключи.");
                    break;
                }
                if (command == "ADD" && parts.Length >= 3)
                {
                    string user = parts[1];
                    string website = input.Substring(input.IndexOf(user) + user.Length + 1);
                    if (!d.ContainsKey(user))
                    {
                        d[user] = new Stack<string>();
                    }
                    d[user].Push(website);
                    Console.WriteLine($"{user} посети {website}.");
                }
                else if (command == "BACK" && parts.Length >= 2)
                {
                    string user = parts[1];

                    if (!d.ContainsKey(user))
                    {
                        d[user] = new Stack<string>();
                    }

                    if (d[user].Count > 0)
                    {
                        string site = d[user].Pop();
                        Console.WriteLine($"{user} се върна от {site}.");
                    }
                    else
                    {
                        Console.WriteLine($"{user} няма история.");
                    }
                }
                else if (command == "HISTORY" && parts.Length >= 2)
                {
                    string user = parts[1];
                    if (!d.ContainsKey(user) || d[user].Count == 0)
                    {
                        Console.WriteLine($"{user} няма история.");
                    }
                    else
                    {
                        Console.WriteLine($"История на {user}:");
                        foreach (var site in d[user])
                        {
                            Console.WriteLine($"> {site}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Невалидна команда.");
                }
            }
        }
    }
}

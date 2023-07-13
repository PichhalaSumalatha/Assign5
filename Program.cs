using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string username = "admin";
                string password = "password";
                int attempts = 3;

                while (attempts > 0)
                {
                    Console.Write("Enter username: ");
                    string inputUsername = Console.ReadLine();

                    Console.Write("Enter password: ");
                    string inputPassword = Console.ReadLine();

                    if (inputUsername == username && inputPassword == password)
                    {
                        Console.WriteLine("Login successful.");
                        break;
                    }
                    else if (inputUsername == username)
                    {
                        Console.WriteLine("Invalid password.");
                        attempts--;
                    }
                    else
                    {
                        Console.WriteLine("Invalid username.");
                        attempts--;
                    }

                    if (attempts > 0)
                    {
                        Console.WriteLine($"You have {attempts} attempt(s) remaining.\n");
                    }
                    else
                    {
                        Console.WriteLine("Login failed.");
                    }
                }
            }
        }

    }

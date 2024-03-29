﻿using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using Design_Patterns_Assignment.ObserverPattern.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    internal class Observer : IObserver
    {
        public IEmailSubject Email { get; set; }
        public IEmailWatcher EmailWatcher { get; set; }

        public Observer(IEmailSubject email, IEmailWatcher emailWatcher)
        {
            Email = email;
            EmailWatcher = emailWatcher;
        }

        public void Run()
        {
            Console.WriteLine("Observer");

            Email.RegisterObserver(EmailWatcher);

            Console.WriteLine("Please choose an action");
            Console.WriteLine("");
            Console.WriteLine("1. Check email");
            Console.WriteLine("2. Subscribe/Unsubscribe");
            Console.WriteLine("3. Exit the program");

            while (true)
            {
                var userInput = Console.ReadKey(intercept: true).Key;
                switch (userInput)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        
                        Email.Check();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        if (Email.Observers.Contains(EmailWatcher))
                        {
                            Email.UnRegisterObserver(EmailWatcher);
                        }
                        else
                        {
                            Email.RegisterObserver(EmailWatcher);
                        }
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }
    }
}
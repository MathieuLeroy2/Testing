﻿using System;

namespace TerminalSelectionMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tutorial - Terminal Selection Menu\n");

            // Let's create an instance of the class menu with a certain text
            Menu menu = new Menu("Please select your favorite food from the options.");

            // Let's print the result to the terminal
            Console.WriteLine(menu);
        }
    }
}

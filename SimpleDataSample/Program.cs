﻿using System;

namespace SimpleDataSample
{
  class Program
  {
    static void Main(string[] args)
    {
      do
      {
        ShowOptions();
        switch (Console.ReadLine())
        {
          case "1":
            var OpenDbDemo = new OpenDatabaseSamples();
            OpenDbDemo.RunAll();
            break;
          case "2":
            var AllMethodDemo = new AllMethodSamples();
            AllMethodSamples.RunAll();
            break;
          case "3":
            var FindByMethodDemo = new FindByMethodSamples();
            FindByMethodSamples.RunAll();
            break;
          case "x":
          case "X":
            Console.WriteLine("Fin");
            return;
          default:
            Console.WriteLine("Not a valid option. Choose again");
            break;
        }
      } while (true);
    }

    private static void ShowOptions()
    {
      Console.WriteLine();
      Console.WriteLine("--------");
      Console.WriteLine();
      Console.WriteLine("Simple.Data Samples");
      Console.WriteLine("Choose from the following options");
      Console.WriteLine();
      Console.WriteLine("1. Open Database Demos");
      Console.WriteLine("2. Basic Selection with All()");
      Console.WriteLine("3. Basic Selection with FindBy()");
      Console.WriteLine("X. Quit");
      Console.WriteLine();

    }
  }
}

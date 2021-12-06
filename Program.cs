using System;
using RpgGame_Dio.src.entities;

namespace dotnet_poo
{

  class Program
  {


    static void Main(string[] args)
    {
      Hero arus = new Hero("Arus", 23, "Knight");
      Wizzard wizard = new Wizzard("Jenica", 23, "White Wizzard");

      Console.WriteLine(arus.Attack());
      Console.WriteLine(wizard.Attack());


    }

  }
}
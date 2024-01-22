using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.Timers;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main()
    {
        char menu;
        Console.WriteLine("A.Saltar");
        Console.WriteLine("B.Correr");
        Console.WriteLine("C.Ajupir-se");
        Console.WriteLine("D.Amagar-se");
        menu=Convert.ToChar(Console.ReadLine());

        Console.WriteLine(Menu(menu));

    }

    public static string Menu(char menu)
    {
      if (menu == 'a' || menu=='A') { return "Salto"; }
      if (menu == 'b' || menu == 'B') {  return "Corro"; }
      if (menu=='c' || menu == 'C') { return "M'ajupo"; }
      if (menu=='d'|| menu == 'D') { return "M'amago"; }
        return "Entrada no valida";

    }



}
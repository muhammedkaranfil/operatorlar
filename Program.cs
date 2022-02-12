// See https://aka.ms/new-console-template for more information


namespace operatorler // Note: actual namespace depends on the project name.
using System

{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            //ATAMA VE İŞLEMLİ ATAMA

            int x = 3;
            int y = 3;
            y = y + 2;
         
            Console.WriteLine("y");
            y += 2;
            Console.WriteLine("y");
            y/=1;
            Console.WriteLine("y");
            x  *=2;
            Console.WriteLine("y");
        Console.WriteLine("*****Mantıksal operatörler*****");
        // MANTISAL OPERATÖRLER
        // ||,&&,!
        bool isSuccess = true;
        bool isComplated = false;
        if(isSuccess && isComplated )
          Console.WriteLine("Perfect!");
        if(isSuccess ||isComplated )
             Console.WriteLine("Great!");
              if(isSuccess ! isComplated )
        Console.WriteLine("Fine!");
         Console.WriteLine("*****ilişkisel operatörler*****");


        }
    }

   
    {
    }
}


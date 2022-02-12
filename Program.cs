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
         //ilişkisel operatörler
         //<,> ,<=, ==,  !=
         int a = 3;
         int b = 4;
         bool sonuc = a<b;
           Console.WriteLine(sonuc);
           sonuc = a>b;
           Console.WriteLine(sonuc);
           sonuc = a>=b;
           Console.WriteLine(sonuc);
           sonuc =a<=b;
           Console.WriteLine(sonuc);
           sonuc = a==b;
           Console.WriteLine(sonuc);
           sonuc = a!=b;
           Console.WriteLine(sonuc);
           Console.WriteLine("*****aritmetik operatörler*****");
           // , /, *,  +,-
           int sayi1 = 10;
           int sayi2 = 5;
           int sonuc  = sayi1/sayi2;
           Console.WriteLine(sonuc);
           sonuc1 = sayi1* sayi2;
           Console.WriteLine(sonuc);
            sonuc1 = sayi1+ sayi2;
           Console.WriteLine(sonuc);
            sonuc1 = sayi1 ++;
           Console.WriteLine(sonuc);
           // % mod alır
          int  sonuc2 = 20%3;
           Console.WriteLine(sonuc2);
        
        
 









        }

    }

   
    {
    }
}


using System;

namespace Lesson2App
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Введите переменную A: ");
            int A=int.Parse(Console.ReadLine());
            Console.Write("Введите переменную B: ");
            int B=int.Parse(Console.ReadLine());
            if (A>B) 
            {
               B=A;
               Console.WriteLine(B);
            }
            else if (A<B)
            {
               A=B;
               Console.WriteLine(A);
            } 
            
            else
            {
               A=0;
               B=0;
               Console.WriteLine(A);
               Console.WriteLine(B);    
            }
        }
    }
}

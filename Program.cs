using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            lexi lex = new lexi(new Numbers("en"));
            
            int[] arr = lex.load(0,5);
            Console.WriteLine("------------BEFORE---------------");
            lex.print(arr);
            lex.sort(arr);
            Console.WriteLine("------------AFTER---------------");
            lex.print(arr);

            arr = lex.load(75,84);
            Console.WriteLine("------------BEFORE---------------");
            lex.print(arr);
            lex.sort(arr);
            Console.WriteLine("------------AFTER---------------");
            lex.print(arr);


            arr = lex.load(7,12);
            Console.WriteLine("------------BEFORE---------------");
            lex.print(arr);
            lex.sort(arr);
            Console.WriteLine("------------AFTER---------------");
            lex.print(arr);

            lex = new lexi(new Numbers("jp"));
            int[] arrjp = lex.load(0,5);
            Console.WriteLine("------------BEFORE---------------");
            lex.print(arrjp);
            lex.sort(arrjp);
            Console.WriteLine("------------AFTER---------------");
            lex.print(arrjp);
        }
    }
}

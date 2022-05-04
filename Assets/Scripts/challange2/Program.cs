using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new calc();
            string[] arr = {"1 2 +","2 1 - 3 +","4 2 /", "2 1 - 3 + 4 *","2 1 - 3 4 * +", "2 1 3 4 * - +"};
            for(int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i]);
                Console.WriteLine(c.Evaluate(arr[i]));
            }
        }
    }
}

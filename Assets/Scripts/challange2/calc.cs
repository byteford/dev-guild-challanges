using System;
using System.Collections.Generic;
using System.Linq;
namespace two{
    class calc{
        int devide(int x, int y){
            return y/x;
        }
        int minus(int x, int y){
            return y-x;
        }
        public int Evaluate(string expression){
            string[] arr = expression.Split(" ");
            Stack<int> buffer = new Stack<int>();
            for(int i = 0; i < arr.Length; i++){
                switch(arr[i]){
                    case "+":
                        buffer.Push(buffer.Pop()+buffer.Pop());
                        break;
                    case "-":
                        buffer.Push(minus(buffer.Pop(),buffer.Pop()));
                        break;
                    case "*":
                        buffer.Push(buffer.Pop()*buffer.Pop());
                        break;
                    case "/":
                        buffer.Push(devide(buffer.Pop(),buffer.Pop()));
                        break;
                    default:
                        int result;
                        if(Int32.TryParse(arr[i], out result)){
                            buffer.Push(result);
                        }
                        continue;
                }
            }
            return buffer.ElementAt(0);
        }
    }
}
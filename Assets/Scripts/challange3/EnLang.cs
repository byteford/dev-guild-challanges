using System.Linq;
namespace Three{
    public class EnLang : lang
    {
        string[] zero = {"zero"};
        string[] unit = {
            "one", 
            "two", 
            "three", 
            "four", 
            "five",
            "six",
            "seven",
            "eight",
            "nine"
        };
        string[] teens = {
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "forteen",
            "fifteen",
            "sixteen",
            "seventeen",
            "eightteen",
            "nineteen"
        };
        string[] tens = {
            "twenty",
            "thirty",
            "forty",
            "fifty",
            "sixty",
            "seventy",
            "eighty",
            "ninety"
        };
        string[] bigger = {
            "",
            "hundred"
        };
        public EnLang(){
            negative = "minus";
        }
        public override string[] getnumbers()
        {
            string[] arr = zero;
            for(int i = 0; i < bigger.Length; i++){
                arr = computeLoop(arr, i,0);
            }
            return arr;
        }
        public string[] computeLoop(string[] arr, int start, int count){
    
             
            if(count == 0){
                arr = arr.Concat(buildwords(bigger[start], unit, bigger[start] != "")).ToArray();
                arr = arr.Concat(buildwords(bigger[start], teens, false)).ToArray();
                for (int j = 0; j < tens.Length; j++){
                    arr = arr.Concat(buildwords(bigger[start],buildwords(tens[j], unit, true),false)).ToArray();
                }
            }else if( count <= start){
                for(int i = 0; i < unit.Length; i++){
                    string pre = unit[i] + " " + bigger[count];
                    arr = arr.Concat(buildwords(pre,computeLoop(arr,start, count + 1),false)).ToArray();
                }
            } 
            if(count <start)
                arr = arr.Concat(computeLoop(arr,start,count +1)).ToArray();
            return arr;
            
        }
    }
}
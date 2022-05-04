using System.Linq;

namespace Three{
    class Numbers{
        public string[] words;
        public static string[] options = {"en", "jp"};
        public string At(int i){
            return words[i];
        }
        public string this[int i]{
            get{return words[i];}
        }
        string[] buildwords(string pre, string[]suff){
            string[] arr = new string[suff.Length +1];
            arr[0] = pre;
            for(int i = 0; i < suff.Length; i++){
                arr[i+1] = pre + " " + suff[i];
            }
            return arr;
        }
        public Numbers(string lang){
            
            switch (lang){
                case "en":
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
                    string[] arr =zero.Concat(unit).Concat(teens).ToArray();
                    for (int i = 0; i < tens.Length; i++){
                        arr = arr.Concat(buildwords(tens[i], unit)).ToArray();
                    }
                    this.load(arr);
                    break;
                case "jp":
                    string[] zerojp = {"ゼロ"};
                    string[] unitjp = {
                        "一", 
                        "二", 
                        "三", 
                        "四", 
                        "五",
                        "六",
                        "七",
                        "八",
                        "九"
                    };
                    string[] arrjp =zerojp.Concat(unitjp).Concat(buildwords("十",unitjp)).ToArray();
                    for (int i = 1; i < unitjp.Length; i++){
                        arrjp = arrjp.Concat(buildwords(unitjp[i], unitjp)).ToArray();
                    }
                    this.load(arrjp);
                    break;
                default:
                    break;
            }
        }
        public Numbers(string[] arr){
            this.load(arr);
        }
        void load(string[] arr){
            this.words = arr;
        }

        public override string ToString(){
            string str = "";
            for( int i = 0 ; i < words.Length; i ++){
                str += i+ ": " + words[i] + "\n";
            }
            return str;
        }
    }
}
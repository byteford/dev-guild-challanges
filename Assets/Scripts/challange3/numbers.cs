using System;
using System.Linq;
using UnityEngine;
namespace Three{
    class Numbers{
        public string[] words;
        public static string[] options = {"en", "jp"};
        public static string negative = "";
        public string At(int i){
            return words[i];
        }
        public string this[int i]{
            get{return i >= 0 ? words[i] : negative + " " + words[Math.Abs(i)];}
        }
        
        public Numbers(string lang){
            
            switch (lang){
                case "en":
                    EnLang en = new EnLang();
                    this.load(en.getnumbers());
                    negative = en.negative;
                    break;
                case "jp":
                    // string[] zerojp = {"ゼロ"};
                    // string[] unitjp = {
                    //     "一", 
                    //     "二", 
                    //     "三", 
                    //     "四", 
                    //     "五",
                    //     "六",
                    //     "七",
                    //     "八",
                    //     "九"
                    // };
                    // string[] arrjp =zerojp.Concat(unitjp).Concat(buildwords("十",unitjp, true)).ToArray();
                    // for (int i = 1; i < unitjp.Length; i++){
                    //     arrjp = arrjp.Concat(buildwords(unitjp[i], unitjp,true)).ToArray();
                    // }
                    // this.load(arrjp);
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
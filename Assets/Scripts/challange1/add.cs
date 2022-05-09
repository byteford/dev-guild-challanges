using UnityEngine;
using System;
namespace three{
    class calc{
        public static string compute(string a, string b, int numBase=2){
            int ai = Convert.ToInt32(a, numBase);
            int bi = Convert.ToInt32(b, numBase);
            return Convert.ToString(ai + bi, numBase);
        }
    }
}
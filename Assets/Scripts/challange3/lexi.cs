using System;
using UnityEngine;
namespace Three{
    class lexi{

        public static int[] load(int a, int b){
            int[] arr = new int[Math.Abs(b - a)+1];
            Debug.Log(arr.Length);
            for(int i = 0; i <= Math.Abs(b - a); i++){
                arr[i] = i+a;
            }
            return arr;
        }
        public static int[] sort(int[] arr, Numbers langarr){
            quickSort(arr, langarr,0,arr.Length-1);
            return arr;
        }

        public static string ToString(int[] arr, Numbers langarr){
            string str = "";
            for(int i = 0; i < arr.Length; i++){
                str += arr[i] + ": " +langarr[arr[i]] + "\n";
            }
            return str;
        }


        static int Partition(int[] arr, Numbers langarr, int left, int right) {
         int pivot;
         pivot = arr[left];
         while (true) {
            while (string.Compare(langarr[arr[left]],langarr[pivot]) < 0) {
               left++;
            }
            while (string.Compare(langarr[arr[right]], langarr[pivot]) > 0) {
               right--;
            }
            if (left < right) {
               int temp = arr[right];
               arr[right] = arr[left];
               arr[left] = temp;
            } else {
               return right;
            }
         }
      }
        static void quickSort(int[] arr, Numbers langarr, int left, int right) {
         int pivot;
         if (left < right) {
            pivot = Partition(arr, langarr, left, right);
            if (pivot > 1) {
               quickSort(arr, langarr, left, pivot - 1);
            }  
            if (pivot + 1 < right) {
               quickSort(arr, langarr, pivot + 1, right);
            }
         }
      }

    }
}
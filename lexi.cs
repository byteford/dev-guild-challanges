using System;
namespace app{
    class lexi{

        public Numbers words;
        public lexi(Numbers w){
            this.words = w;
        }
        public int[] load(int a, int b){
            int[] arr = new int[b-a+1];
            for(int i = 0; i <= b-a; i++){
                arr[i] = i+a;
            }
            return arr;
        }
        public int[] sort(int[] arr){
            quickSort(arr,0,arr.Length-1);
            return arr;
        }

        public void print(int[] arr){
            for(int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i] + ": " +words[arr[i]]);
            }
            return;
        }


        int Partition(int[] arr, int left, int right) {
         int pivot;
         pivot = arr[left];
         while (true) {
            while (string.Compare(words[arr[left]],words[pivot]) < 0) {
               left++;
            }
            while (string.Compare(words[arr[right]], words[pivot]) > 0) {
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
        void quickSort(int[] arr, int left, int right) {
         int pivot;
         if (left < right) {
            pivot = Partition(arr, left, right);
            if (pivot > 1) {
               quickSort(arr, left, pivot - 1);
            }  
            if (pivot + 1 < right) {
               quickSort(arr, pivot + 1, right);
            }
         }
      }

    }
}
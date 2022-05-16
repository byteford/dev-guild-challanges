namespace Three{
    public abstract class lang{
        public string negative;
        protected string[] buildwords(string pre, string[]suff, bool byself){
            bool usePre = byself;
            string[] arr = new string[suff.Length + (usePre? 1: 0)];
            if(usePre)
                arr[0] = pre;

            for(int i = 0; i < suff.Length; i++){
                arr[i+(usePre? 1: 0)] = pre + " " + suff[i];
            }
            return arr;
        }
        public abstract string[] getnumbers();
    }
}
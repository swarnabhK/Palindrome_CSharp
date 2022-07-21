using System;
namespace palindromecheck {
   class Program {
      public static Boolean isPalindrome(string s){
        int left = 0;
        int right = s.Length-1;
        while(left<right){
          if(s[left]!=s[right]){
            return false;
          }
          left+=1;
          right-=1;
        }
        return true;
      }
      static void Main(string[] args) {
         Console.WriteLine(isPalindrome("racecar"));
         Console.WriteLine(isPalindrome("racecarss"));
      }
   }
}

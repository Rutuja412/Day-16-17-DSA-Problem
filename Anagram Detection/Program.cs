using System;

namespace Anagram_Detection
{
    public class Anagram
    {
        
        static void Main(string[] args)
        {
            Anagram anagram = new Anagram();
            // Console.WriteLine("Hello World!");
            string FirstString, SecondString;
            Console.WriteLine("Enter Two String for detect anagram :");
            FirstString = Console.ReadLine();
            SecondString = Console.ReadLine();
            
            
                //Convert string to char array
                char[] savechar1= FirstString.ToCharArray();
                char[] savechar2 = SecondString.ToCharArray();

                //sort the char array
                Array.Sort(savechar1);
                Array.Sort(savechar2);

            string str1=new string(savechar1);
            string str2=new string(savechar2);  
                // if sorted char array are same then the string is anagram
                
                if ( str1.Equals(str2)) 
                {

                    Console.WriteLine(FirstString +   "and" +   SecondString +    "are anagram.");
                }
                else 
                {
                    Console.WriteLine(FirstString +   "and" +    SecondString +    "are not anagram.");
                }





        }
    }
}

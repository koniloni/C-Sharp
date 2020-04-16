using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {     
            int count1=0;            
            Console.WriteLine("Prime Numbers below 1000 are:");
            
            for(int i=0;i<1000;++i) // Find all prime numbers below 1000
            { 
                int j=1;
                int count=0;

                // Check if the number is only evenly divisible with 1 and that number
                while(j<=i) 
                {
                    if(i%j==0)
                    {
                        ++count;                        
                    }
                    ++j;
                }                

                if(count==2)
                {
                    Console.Write(i + " ");
                    ++count1;
                }   

                if(count1==20) // Print newline after every 20 numbers
                {
                    Console.Write("\n");
                    count1=0;
                }         
            }            
        }
    }
}

using System;

namespace C_assignment2_b
{
    public class Fibonacci{
        int i,sum=0;
        int a,b,c;
       public int letsgetitstarted(int n){

if (n==1)
{
    Console.WriteLine("0");
    return(0);
}
else if (n==2)
{
    Console.WriteLine("0");
    Console.WriteLine("1");
    return(1);
}
else{
    Console.WriteLine("0");
    Console.WriteLine("1");
     a=0;b=1;c=0;
    for(i=1;i<n-1;i++){
   
    c=b;
    b=a+b;
    a=c;
    
        Console.WriteLine(b);
       sum=(sum+b);

        
    }
     Console.WriteLine(sum+1);
    return (sum+1);
}
    }
    class Program
    {
        static void Main()
        {int n;
            Fibonacci f = new Fibonacci();
            Console.WriteLine("Enter the length of the fibonacci sequence");
n= int.Parse(Console.ReadLine());
            f.letsgetitstarted(n);
        }
    }
    }
}
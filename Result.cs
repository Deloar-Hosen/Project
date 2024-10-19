using System;

class Result
{
static void Main()
{
   int num;
   Console.Write($"Enter number:");
try
{
   num=Convert.ToInt32(Console.ReadLine());
  if(num%2==0)
  {
    Console.WriteLine($"number is even.");
  }
  else
  {
    Console.WriteLine($"number is odd.");
    
  }
}
catch(Exception e)
{
    Console.WriteLine($"Enter a valid number and the exeption is {e}");  
}

}
}




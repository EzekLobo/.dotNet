using System;

class Program
{
    static void Main()
    {
       
        int num1 = 7;
        int num2 = 3;
        int num3 = 10;

        
        if (num1 > num2 && num3 == num1 + num2)
        {
            Console.WriteLine("num1 é maior do que num2 e num3 é igual a num1 + num2");
        }
        else if(num3 == num1 + num2){
            Console.WriteLine("num1 não é maior do que num2, mas num3 é igual a num1 + num2");
        }else{
            Console.WriteLine("num1 não é maior do que num2 e num3 não é igual a num1 + num2");
        }
    }
}

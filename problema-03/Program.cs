using System;

class Program
{
    static void Main()
    {
        /*Quando um valor double é convertido para um int, a parte fracionária é sempre truncada, 
        independentemente  de quão grande ou pequena seja. Isso significa que o valor após o ponto decimal
         é descartado e apenas a parte inteira é mantida.*/
        double d = 9.999999999999;
        int i = (int)d;
        Console.WriteLine("Int truncado:"+i);


        /*Caso deseje levar em conta a parte fracionária ao converter um double para um int,pode 
        arredondar o valor double para o int mais próximo antes de fazer a conversão. Isso pode ser 
        feito usando o método Math.Round().*/

        i = (int)Math.Round(d);
        Console.WriteLine("Int arredondado: "+i); 

    }
}


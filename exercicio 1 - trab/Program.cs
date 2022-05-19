using System;

namespace exercicio_1___trab
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario, dolar, euro, salariof, aumento=0;

            Console.WriteLine("Qual o valor do salario?");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario <= 1200) 
            {
                aumento =  (salario * 20 / 100);
             }
            
            if (salario > 1200 && salario <= 2000)
            {
                aumento =  (salario * 13 / 100);
            }
             
            if (salario > 2000 && salario <= 2500)
            {
                aumento =  (salario * 10 / 100);
            }

            if (salario >2500)
            {
                aumento = (salario * 5 / 100);
            }

            
            Console.WriteLine("O valor do salario com aumento é " + (salario + aumento));            

            dolar = salario * 4.70;
            Console.WriteLine("O salario em dolares é " + dolar);

            euro = salario * 5.20;
            Console.WriteLine("O salario em euro é " + euro);




        }
    }
}

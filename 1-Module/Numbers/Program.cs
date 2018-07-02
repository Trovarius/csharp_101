using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/quick-starts/numbers-in-csharp-local

            int var1 = 0; //inteiro padrão ou Int32
            short  var2 = 0; //int16 ou short
            byte var3 = 0; // int8 
            long var4 = 0; // int64 ou bigint

            int a  = 10;
            int b = 6;

            int c = a + b; //adição
            Console.WriteLine(c);
            c = a - b; //subtração
            Console.WriteLine(c);
            c = a * b; // multiplicação
            Console.WriteLine(c);
            c = a / b; // divisão
            Console.WriteLine(c);
            c = a % b; // mod
            Console.WriteLine(c);

            // Opreçaões
            c = (a+b) * 10 /2;
            Console.WriteLine(c);

            //Min e Max of integers
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            //Overflow
            int max = int.MaxValue;
            int d = max + 3;
            Console.WriteLine(d);

        }

        public void WorkWithDouble()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a  + b) / c;
            Console.WriteLine(d);

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        public void WorkWithFixedPrecision()
        {
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        //Desafio- calcular a área de um circulo aonde o radius é 2.50 cm

        public void AreaCirulo()
        {
            double a = (2.50 * 2.50 ) * Math.PI;
            Console.WriteLine(a);
        }

        public double AreaCirulo(double valorArea)
        {
            if(valorArea < 0) return 0;

            double valor1 = valorArea;
            double valor2 = valorArea;
            double PI = 3.14;

            double resultado = valor1 * valor2 * PI;
            return  resultado;
        }

        public void AreaCirulo_AreaValendo2_Resultado12()
        {
            double valorArea = 2;
            var resultado = AreaCirulo(2);

            if(resultado == 6)
                Console.WriteLine("Funcionou com 2 resultado 6");
            else
                Console.WriteLine("ERRO: Valor esperado de 6 mas retornou " + resultado);
        }

        public void AreaCirulo_AreaValendo3_Resultado36()
        {
            double valorArea = 2;
            var resultado = AreaCirulo(2);

            if(resultado == 6)
                Console.WriteLine("Funcionou com 2 resultado 36");
            else
                Console.WriteLine("ERRO: Valor esperado de 6 mas retornou " + resultado);
        }

        public void AreaCirulo_AreaValendo0_Resultado3_14()
        {
            double valorArea = 2;
            var resultado = AreaCirulo(2);

            if(resultado == 6)
                Console.WriteLine("Funcionou com 2 resultado 6");
            else
                Console.WriteLine("ERRO: Valor esperado de 6 mas retornou " + resultado);
        }

         public void AreaCirulo_AreaValendoX_ResultadoY(double x, double y)
        {
            double valorArea = 2;
            var resultado = AreaCirulo(2);

            if(resultado == 6)
                Console.WriteLine("Funcionou com 2 resultado 6");
            else
                Console.WriteLine("ERRO: Valor esperado de 6 mas retornou " + resultado);
        }
    }
}
using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Hello";
            string string2 = "World";

            string string3 = string1 + string2;

            Console.WriteLine(string3);
        }

        public void Concat()
        {
            string string1 = "hello";
            string1 += " World";
            Console.WriteLine(string1);

            //Concat with string.concat
            string nome = "Thunder";
            string string2 = string.Concat("hEllO", "wolrd", nome);

            Console.WriteLine(string2);

            //Format
            string string3 = string.Format("Hello World, {0} {1}", "Thunder", "Lindao");
            Console.WriteLine(string3);

            //interpolation
            string hello = "Hello";
            string world = "World";
            string string4 = $"Primeiro programa é sempre {hello} {world}";
            Console.WriteLine(string4);
        }

        public void Escape()
        {
            string string1 = " \"Use barra para escapar as aspas\" ";
            string string2 = @" Use @ para escapas quebra de linhas
            e \ (barras)";
            string string3 = " Quebra de linha , \r\n Muitoo melhor que char(10) char(13)";

            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);
        }

        public void Chars()
        {
            char char1 = 'a';
            char char2 = 'b';

            char char3 = "Toda string é um ARRAY de chars, pegando a letra \"T\""[0];
            Console.WriteLine(char1);
            Console.WriteLine(char2);
            Console.WriteLine(char3);
        }
    }
}

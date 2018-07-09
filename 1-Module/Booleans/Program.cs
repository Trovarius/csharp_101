using System;

namespace Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
           bool bool1 = true;
           bool bool2 = false;
           bool bool3;

           Console.WriteLine(bool1);
           Console.WriteLine(bool2);
           Console.WriteLine(bool3);
        }

        public void Negative()
        {
            var bool1 = true;
            var bool2 = false;

            var bool0 = bool1 == bool2;
            var bool3 = bool1 != bool2;
            var bool4 = !bool1;
            var bool5 = !(bool1 == bool2);
            var bool6 = bool1 & bool2;
            var bool7 = bool1 && bool2;
            
            var bool8 = bool1 | bool2;
            var bool9 = bool1 || bool2;
        }

        public void if_statement()
        {
            bool brasilPerdeu = true;
            if(brasilPerdeu){
                Console.WriteLine("Vai Bélgica");
            }

            brasilPerdeu = false;

            if(brasilPerdeu){
                Console.WriteLine("Perdeu!!!");
            }

            var belgicaGanhou = true;

            if(belgicaGanhou && brasilPerdeu){
                Console.WriteLine("Nada");
            } else if (brasilPerdeu || belgicaGanhou){
                Console.WriteLine("Alguém ganhou?");
            } else {
                Console.WriteLine("Vai dar zebra");
            }
        }

        public void using_var()
        {
            var numero =0;
            var numeroCasaDecimal = 0.0;
            var boleano = true;
            var palavra = "Oi gente!";
            var caractere = 'a';
            var a; //ERRROOOO!!
        }

        enum TipoPessoa
        {
            Fisica,
            Juridica
        }

        enum Sexo : int
        {
            Masculina = 0,
            Feminino = 1,
            Outros = 2
        }

        [Flags] 
        public enum Pets {
            None = 0,
            Dog = 1,
            Cat = 2,
            Bird = 4,
            Rabbit = 8,
            Other = 16
        }

        public void ENUM_SAMPLE()
        {
            var desc = "Pensa em tabela de dominio do sistema";
            var tpPessoa =  TipoPessoa.Fisica;
            var tpPessoaJuridica = TipoPessoa.Juridica;

            var sexo = Sexo.Masculina;
            int idSexo = (int)sexo;
            int idSexoOposto = 2;
            
            Sexo sexo2 = (Sexo)Enum.Parse(typeof(Sexo), idSexoOposto.ToString());

            Pets animaisEstimacao = Pets.Cat | Pets.Dog;

            if(animaisEstimacao.HasFlag(Pets.Dog))
            {
                Console.WriteLine("Possuiu um cão");
            }

             if(animaisEstimacao.HasFlag(Pets.Cat))
            {
                Console.WriteLine("Possuiu um gato");
            }
        }

        public void Array_Sample()
        {
            string[] participantes = new string[8];
            participantes[0] = "Thunder";
            participantes[2] = "Panda";
            participantes[3] = "Gru";

            string[] compareceram = new string[] { "Talita", "Andreia", "Zoli" };

            compareceram[2] = "Poliseu";

            compareceram[3] = "Erro, index out of range";
            
            var index = 0;
            while(participantes.Length < index)
            {
                Console.WriteLine("Esta participando:" + participantes[index]);
                index += 1; //index++
            }

            index = participantes.Length;

            do
            {
                --index;
                Console.WriteLine("Esta participando:" + participantes[index]);  
                //outro caso
                //Console.WriteLine("Esta participando:" + participantes[--index]); 
            } while(index >= 0);


            for (int i = 0; i < participantes.Length; i++)
            {
                Console.WriteLine("Esta participando:" + participantes[i]);
            }

            for (int i = 0; i < compareceram.Length; i++)
            {
                Console.WriteLine("Compareceu:" + compareceram[i]);
            }

            for (int i = 0; i < participantes.Length; i++)
            {
                for (int k = 0; k < compareceram.Length; k++)
                {
                    if(participantes[i] == compareceram[k])
                        Console.WriteLine("Falou q vinha e veio:" + participantes[i]);
                }
            }

            for (int i = 0; i < participantes.Length; i++)
            {
                foreach (var comp in compareceram)
                {
                    if(participantes[i] == comp)
                    {
                        Console.WriteLine("Falou q vinha e veio:" + participantes[i]);
                        break;
                    }
                }
            }
        }

        public void SWITCH_sample()
        {
            int index = 0;
            switch(index)
            {
                case 1: 
                    Console.WriteLine("valor 1"); 
                    break;
                case 2:
                    Console.WriteLine("valor 2"); 
                    break;
                case 3:
                    Console.WriteLine("valor 3"); 
                    break;
                default:
                    Console.WriteLine("valor padrão"); 
                    break;
            }

            switch("thunder")
            {
                case "Thunder": 
                    Console.WriteLine("valor 1");
                case "Panda":
                    Console.WriteLine("valor 2"); 
                case "Rodrigo":
                    Console.WriteLine("valor 3"); 
                default:
                    Console.WriteLine("valor padrão"); 
                    break;
            }

            var diaSalario = 15;

            switch(diaSalario)
            {
                case 10: 
                case 25: 
                    Console.WriteLine("Caiu");
                    break;
                default:
                    Console.WriteLine("Sem grana vamos no lumie"); 
                    break;
            }

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("Final de semana");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Segunda :(.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Sexta :))))).");
                    break;
                default:
                    Console.WriteLine("Pré Sexta.");
                    break;   
            }
        }

        public void datetime_sample()
        {
            DateTime data1 = new DateTime(); // 1970 01 01
            DateTime dataAtual = DateTime.Now;
            DateTime dataAtualutc = DateTime.UtcNow;

            DateTime ADD1 = dataAtual
                            .AddDays(1)
                            .AddHours(1)
                            .AddMilliseconds(1)
                            .AddYears(-1);

            var localTime = ADD1.ToLocalTime();
            var longdate = ADD1.ToLongDateString();
            var shortdate = ADD1.ToShortDateString();

            var format = ADD1.ToString("yyyy/MM/dd");
            //http://www.csharp-examples.net/string-format-datetime/
        }

        public void metodo1()
        {

        }

        public string metodo2()
        {
            return "";
        }

        private string metodo3()
        {
            return "";
        }

        private string metodo4(string a)
        {
            return a + " valor de a mais isso aqui";
        }

        private string metodo4(string a, int i)
        {
            i++;
            return a + " valor de a mais isso aqui";
        }

        private string metodo5(string a, int[] i)
        {
            
            return a + " valor de a mais isso aqui" + i.Length.ToString();
        }

        private string metodo6(string a, params int[] i)
        {
            
            return a + " valor de a mais isso aqui" + i.Length.ToString();
        }

        private string metodo7(string a, int i = 0)
        {
            i++;
            return a + " valor de a mais isso aqui";
        }

        private string metodo8(ref int a)
        {
            a = 0;
            return a.ToString();
        }
        
        const int CONSTANTE = 0; 
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola mundo!");
            // tipos de dados   
            // int double char string bool
            int idade;
            double salario, altura;
            char genero;
            string nome;

            idade = 29;
            salario = 4000.92;
            altura = 1.62;
            genero = 'M';
            nome = "Geraldo Pereira";

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(genero);
            Console.WriteLine(salario);

            //-----------------------------------------------------------------
            //Saída de dados---------------------------------------------------
            //-----------------------------------------------------------------

            Console.WriteLine("Funcionário " + nome + " sexo " + genero +
                " idade " + idade + " recebe R$" + salario);

            //-----------------------------------------------------------------
            //Entrada de dados-------------------------------------------------
            //-----------------------------------------------------------------

            //string x = Console.ReadLine();
            //int x = int.Parse(x);
            //double x = double.Parse(x);
            //char x = char.Parse(x);

            string nome1;
            double salario1;

            Console.WriteLine("Digite o nome da primeira pessoa:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite o salario da primeira pessoa:");
            salario1 = double.Parse(Console.ReadLine());

            Console.WriteLine(nome1);
            Console.WriteLine(salario1);

            //-----------------------------------------------------------------
            //Estrutura de controle--------------------------------------------
            //-----------------------------------------------------------------
            Console.WriteLine("IF");
            int horaDigitada = 2;

            if (horaDigitada == 1)
            {
                Console.WriteLine("Boa noite!");
            }

            // IF ELSE---------------------------------------------------------

            if (horaDigitada < 6)
            {
                Console.WriteLine("Boa noite!");
            }
            else
            {
                Console.WriteLine("Bom dia!");
            }

            // IF ELSE IF-------------------------------------------------------
            Console.WriteLine("IF ELSE IF");
            Console.WriteLine("Digite a hora: ");
            horaDigitada = int.Parse(Console.ReadLine());
            if (horaDigitada > 4 && horaDigitada < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horaDigitada > 12 && horaDigitada < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }


            //-----------------------------------------------------------------
            //Estrutura de repetição-------------------------------------------
            //-----------------------------------------------------------------

            // WHILE-----------------------------------------------------------

            Console.WriteLine("while");
            while (horaDigitada < 18)
            {
                Console.WriteLine(horaDigitada);
                horaDigitada++;
            }

            // FOR-------------------------------------------------------------

            Console.WriteLine("for");
            for (horaDigitada = 1; horaDigitada < 18; horaDigitada++)
            {
                Console.WriteLine(horaDigitada);
            }

            // DO WHILE--------------------------------------------------------
            Console.WriteLine("do while");
            horaDigitada = 1;
            do
            {
                Console.WriteLine(horaDigitada);
                horaDigitada++;
            } while (horaDigitada < 18);

            //-----------------------------------------------------------------
            //VETORES----------------------------------------------------------
            //-----------------------------------------------------------------

            
            double soma, media1;
            
            Console.WriteLine("Quantas notas serão calculadas?");
            int N = int.Parse(Console.ReadLine());
            double[] vetor1 = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite uma nota");
                vetor1[i] = double.Parse(Console.ReadLine()); 
            }

            media1 = 0;
            soma = 0;
            
            for (int i = 0; i < N; i++)
            {
                soma = soma + vetor1[i];
                media1 = soma / N;
            }

            Console.WriteLine("A média é " + media1);

            Console.WriteLine("O programa será encerrado! (digite qualquer coisa)");
            N = int.Parse(Console.ReadLine());
        }
    }
}

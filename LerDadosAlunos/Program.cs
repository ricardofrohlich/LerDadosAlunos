using System;
using System.IO;

namespace LerDadosAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha;
            int i = 0;
            int inome = 0, inota = 0;
            double[] nota = new double[100];
            string[] nome = new string[100];
            try
            {
                //StreamWriter sw = new StreamWriter("C:\\Teste\\teste.txt"); //Escrita - Writer
                StreamReader sr = new StreamReader("C:\\Arquivos\\Notas.cad");
                linha = sr.ReadLine(); //aqui leio a primeira linha
                while (linha != null) //se tem algo na primeira linha, entro no laço
                {
                    if (i % 2 == 0)
                    {
                        nome[inome] = linha;
                        inome++;
                    }
                    else
                    {
                        nota[inota] = double.Parse(linha);
                        inota++;

                    }
                    linha = sr.ReadLine(); //aqui vai ler a próxima linha
                    i++;
                }
                mostraNomes(nome, i/2);
                mostraNotas(nota, i/2) ;
                CalculaMedia(nota,i/2);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e);
            }

        }

        private static void CalculaMedia(double[] nota,int n)
        {
            int i;
            double notas = 0;
            
            for (i = 0; i < n; i++)
                notas += nota[i];

            Console.WriteLine("A média das notas = " + notas / n);
        }

        private static void mostraNotas(double[] nota, int n)
        {
            int i;
            Console.WriteLine("Apresentando as notas dos alunos: ");
            for (i = 0; i < n; i++)
                Console.WriteLine(nota[i]);
        }

        private static void mostraNomes(string[] nome, int n)
        {
            int i;
            Console.WriteLine("Apresentando os nomes dos alunos: ");
            for (i = 0; i < n; i++)
                Console.WriteLine(nome[i]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t --- BEM VINDO AO GERENCIADOR DE ALUNOS! -- ");
            bool executando = true;

            while (executando) {
                Console.WriteLine("\n Digite o que deseja fazer: ");
                Console.WriteLine("1- Cadastrar um aluno");
                Console.WriteLine("2- Listar todos os alunos");
                Console.WriteLine("3- Alterar dados de um aluno");
                Console.WriteLine("4- Remover um aluno");
                Console.WriteLine("5- Sair");

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Aluno.CadastrarAluno();
                        break;

                    case 2:
                        Aluno.ListarAlunos();
                        break;
                }
            }
        }
    }
}

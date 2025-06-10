using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio1
{
    public class Aluno
    {
        public string RA { get; set; }
        public string Nome { get;  set; }
        public int Idade { get;  set; }
        public static List <Aluno> listaAlunos = new List <Aluno> ();
        private static int proximoRA = 1;

        public static void CadastrarAluno()
        {
            Aluno novoAluno = new Aluno();
            novoAluno.RA = proximoRA.ToString();
            Console.WriteLine("Digite o nome do aluno: ");
            novoAluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno: ");
            novoAluno.Idade = int.Parse(Console.ReadLine());
            listaAlunos.Add(novoAluno);
            Console.WriteLine($"Aluno cadastrado com o RA {novoAluno.RA}");
            proximoRA++;
        }
        public static void ListarAlunos()
        {
            Console.WriteLine("\t Listando todos os alunos...");
            foreach (var aluno in listaAlunos) {
                Console.WriteLine($"\n RA: {aluno.RA} \n Nome: {aluno.Nome} \n Idade: {aluno.Idade}");
            }
        }
        public static void AlterarDados()
        {
            Console.WriteLine("Digite o RA do aluno que deseja alterar: ");
            string ra = Console.ReadLine(); 

            if (listaAlunos.Any(a => a.RA == ra)) { }
        }
        public void RemoverAluno()
        {

        }
    }
}

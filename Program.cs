using AlunosCRUD.Entities;

namespace AlunosCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> listaDeAluno = new List<Aluno>();
            Aluno aluno = new Aluno();
            

            Console.WriteLine("Bem-vindo! Aqui você irá conseguir fazer o registro de todos os seus alunos");

            Console.Write("Você vai querer adicionar quantos alunos agora? ");
            int qtdAlunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine("OK! Vamos para o aluno #" + (i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Curso: ");
                string curso = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Email: ");
                string email = Console.ReadLine();

                int id = aluno.SetId();
                int matricula = aluno.SetMatricula();

                listaDeAluno.Add(new Aluno(id ,nome, curso, idade, email, matricula));
            }
            foreach(Aluno aluno1 in listaDeAluno) 
            { 
                Console.WriteLine(aluno1.ToString());
            }
        }
    }
}
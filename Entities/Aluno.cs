namespace AlunosCRUD.Entities
{
    class Aluno
    {
        Random numAleatorio = new Random();
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string  Curso { get; set; }
        public int Idade { get; set; }
        public string  Email { get; set; }
        public int Matricula { get; private set; }

        public Aluno()
        {
            
        }

        public Aluno(int id, string nome, string curso, int idade, string email, int matricula)
        {
            Id = id;
            Nome = nome;
            Curso = curso;
            Idade = idade;
            Email = email;
            Matricula = matricula;
        }

        public int SetId()
        {
            Id = numAleatorio.Next(1, 100);
            return Id;
        }

        public int SetMatricula()
        {
            Matricula = numAleatorio.Next(1000, 9999);
            return Matricula;
        }

        public override string ToString()
        {
            return "ID: " + Id + ", Nome: " + Nome + ", Curso: " + Curso + ", Idade: " + Idade + ", Email: " + Email + ", Matricula: " +Matricula;
        }

    }
}

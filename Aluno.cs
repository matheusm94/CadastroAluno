using System.Collections.Generic;

namespace CadastraAluno
{
    public class Aluno
    {
        private static List<Aluno> alunos = new List<Aluno>();

        public string Nome { get; set; }
        public string Ra { get; set; }
        public string Notas { get; set; }

        public void Salvar()
        {
            alunos.Add(this);
        }

        public static List<Aluno> Todos()
        {
            return alunos;
        }
    }
}

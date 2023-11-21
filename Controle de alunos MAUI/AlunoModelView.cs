using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Reflection;
using System.IO;

namespace Controle_de_alunos_MAUI
{
    public class AlunoViewModel
    {
        public ObservableCollection<Aluno> Alunos { get; set; }

        public AlunoViewModel()
        {
            
            string alunosJson = File.ReadAllText("alunos.json");

            AlunoData jsonAlunos = JsonSerializer.Deserialize<AlunoData>(alunosJson);

            Alunos = jsonAlunos?.alunos ?? new ObservableCollection<Aluno>();
        }
    }

    public class AlunoData
    {
        public ObservableCollection<Aluno> alunos { get; set; }
    }
}

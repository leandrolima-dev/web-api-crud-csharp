using System.ComponentModel.DataAnnotations;
using WebApiBase.Enums;

namespace WebApiBase.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public bool Ativo { get; set; }
        public TurnoEnum Turno { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataAlteracao { get; set; } = DateTime.Now.ToLocalTime();

        public FuncionarioModel(string nome, string sobrenome, DepartamentoEnum departamento, bool ativo, TurnoEnum turno)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Departamento = departamento;
            Ativo = ativo;
            Turno = turno;   
        }

    }
}

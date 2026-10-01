using System.Runtime.CompilerServices;

namespace Academia;

public class Aluno
{
    public String Nome {get; set;} = string.Empty;
    public DateTime DataNascimento {get; set;}
    public string? UserId {get; set;}
    public List<Matricula>? Matriculas {get; set;}
    public List<AvaliacaoFisica>? Avaliacoes {get;set;}
    public List<Inscricao>? Inscricoes {get;set;}
}

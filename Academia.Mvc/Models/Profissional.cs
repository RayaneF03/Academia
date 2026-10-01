using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Academia;

public class Profissional
{
    public int Id { get; set; }
    public string Nome { get; set; } = String.Empty;
    public string Especialidade { get; set; }
    public string? UserId { get; set; }
    public List<Aula>? Aulas { get;set; }
}
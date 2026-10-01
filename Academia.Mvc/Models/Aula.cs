using System.Runtime.CompilerServices;

namespace Academia;

public class Aula
{
public int Id {get; get;}
public string Nome {get; set;} = String.Empty;
    public DayOfWeek DiaSemana { get; set; }
    public TimeSpan Horario { get; set; }
    public int VagasTotais { get; set; }
    public int ProfissionalId { get; set; }
    public Profissional? Profissional { get; set;}
   public List<Inscricao>? Inscricoes { get; set;}
    
}

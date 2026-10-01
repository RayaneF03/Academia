public class Plano
{
    public int ID {get; set;}
    public string Nome {get; set;}
    public decimal ValorMensalidade {get; set;}
    public int DuracaoMeses {get; set;}
    public List<Matricula>? Matriculas {get; set;}
}
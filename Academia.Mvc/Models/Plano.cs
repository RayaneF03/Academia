public class Plano
{
    public int ID { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal ValorMensalidade { get; set; }
    public int DuracaoMeses { get; set; }
    public List<Academia.Matricula>? Matriculas { get; set; }
}
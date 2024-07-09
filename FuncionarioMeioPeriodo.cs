public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    private double salarioHora;
    private double horasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioHora, double horasTrabalhadas) : base (nome, matricula)
    {
        this.salarioHora = salarioHora;
        this.horasTrabalhadas = horasTrabalhadas;
    }

    public override double CalcularSalario()
    {
         return salarioHora * horasTrabalhadas;
    }

    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }

    
    public override void ExibirInfo()
    {
        Console.WriteLine ($"Nome: {nome}\nMatrícula: {matricula}\nHoras Trabalhadas: {horasTrabalhadas}\nSalário Hora: {salarioHora}\nSalário Mensal: {CalcularSalario()}\n Bônus: {CalcularBonus()} ");
    }
}
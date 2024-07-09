public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    private double salarioMensal;

    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base (nome, matricula)
    {
        this.salarioMensal = salarioMensal;
    }

    public override double CalcularSalario()
    {
        return salarioMensal;
    }

    public double CalcularBonus()
    {
        return salarioMensal * 0.10;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine ($"Nome: {nome}\nMatrícula: {matricula}\nSalário Mensal: {CalcularSalario()}\nBonus: {CalcularBonus()} ");
    }
}
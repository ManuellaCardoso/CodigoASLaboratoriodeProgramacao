//A classe FuncionarioTempoIntegral herda de funcionario e implementa Ibonus
public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    //campo privado especifico para funcionarios de tempo integral
    private double SalarioMensal;

    //Construtor da classe FuncionarioTempoIntegral
    //Parâmetros: nome - nome do funcionário, matricula - matrícula do funcionário,
    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome, matricula)
    {
        SalarioMensal = salarioMensal; //salarioMensal - salário mensal do funcionário
    }

    //Implementando o método abstrato CalcularSalario da classe Funcionario
    public override double CalcularSalario()
    {
        return SalarioMensal;
    }

    //Implementando o método abstrato ExibirInformacoes da classe Funcionario
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário Mensal: {SalarioMensal}");
    }

    //Implementando o método da interface IBonus
    //Calcula o bônus do funcionário de tempo integral com base no salário mensal
    public double CalcularBonus()
    {
        return SalarioMensal * 0.1;
    }
}

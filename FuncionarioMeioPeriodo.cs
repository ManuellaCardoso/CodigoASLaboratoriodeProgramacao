//Definindo a classe FuncionarioMeioPeriodo que herda de Funcionario e implementa Ibonus
public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    //Campos especificos para funcionario de meio periodo
    private double SalarioPorHora;
    private int HorasTrabalhadas;

    //Construtor da classe FuncionarioMeioPeriodo
    //Parâmetros: nome - nome do funcionario, matricula - matricula do funcionario
    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, int horasTrabalhadas) : base(nome, matricula)
    {
        SalarioPorHora = salarioPorHora;
        HorasTrabalhadas = horasTrabalhadas;
    }

    //Calcula o salario do funcionario de meio periodo com base no salario por hora e horas
    public override double CalcularSalario()
    {
        return SalarioPorHora * HorasTrabalhadas;
    }

    //Informações específicas do funcionario de meio período
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário por Hora: {SalarioPorHora}, Horas Trabalhadas: {HorasTrabalhadas}");
    }

    //Calcula o bônus do funcionario de meio período com base no salário
    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }
}

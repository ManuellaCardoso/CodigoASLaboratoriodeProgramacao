public class Empresa
{ 
    //lista de funcionarios
    public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();

    //Adicionando um funcionário a lista
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    //removendo funcionario da lista
    public void RemoverFuncionario(int matricula)
    {
        //busca o funcionario da lista pela matricula
        var funcionario = Funcionarios.SingleOrDefault(f => f.Matricula == matricula);

        //se encontrar remove da lista
        if (funcionario != null)
        {
            Funcionarios.Remove(funcionario);
        }
    }
    //exibe as informações de todos os funcionarios da empresa
    public void ExibirFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }
}

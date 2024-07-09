public abstract class Funcionario
{
    //propriedade comum para todos os tipos de funcionarios
    public string Nome { get; set; }
    public int Matricula { get; set; }
    public List<string> Projetos { get; set; }


    //construtor da classe funcionario
    public Funcionario(string nome, int matricula)
    {
        Nome = nome;
        Matricula = matricula;
        Projetos = new List<string>(); //lista de projetos vazia
    }

    //metodos abstratos a serem implementados pelas subclasses
    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();

    //adicionando um projeto9 a lista de projetos -funcionario-
    public void AdicionarProjeto(string projeto)
    {
        Projetos.Add(projeto);
    }

    //adicionando uma lista de projetos a lista de projetos -funcionario-
    public void AdicionarProjeto(List<string> projetos)
    {
        Projetos.AddRange(projetos);
    }
}

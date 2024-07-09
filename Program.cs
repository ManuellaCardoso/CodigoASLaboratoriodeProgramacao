class Program
{
    static void Main(string[] args)
    {
        // Criação de uma instância da classe Empresa
        Empresa empresa = new Empresa();
        // Variável par controle do loop principal do menu
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar Funcionário de Tempo Integral");
            Console.WriteLine("2. Adicionar Funcionário de Meio Período");
            Console.WriteLine("3. Remover Funcionário");
            Console.WriteLine("4. Exibir Informações de Todos os Funcionários");
            Console.WriteLine("5. Adicionar Projeto(s) a um Funcionário");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            // Lê a opção escolhida pelo usuário e tenta converter para int
            if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int opcao))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            // Estrutura switch para executar a ação correspondente a opção escolhida
            switch (opcao)
            {
                case 1:
                    AdicionarFuncionarioTempoIntegral(empresa); // Chama o método para adicionar funcionário de tempo integral
                    break;
                case 2:
                    AdicionarFuncionarioMeioPeriodo(empresa); // Chama o método para adicionar funcionário de meio período
                    break;
                case 3:
                    RemoverFuncionario(empresa); // Chama o método para remover funcionário
                    break;
                case 4:
                    empresa.ExibirFuncionarios(); // Chama o método para exibir todos os funcionários da empresa
                    break;
                case 5:
                    AdicionarProjetos(empresa); // Chama o método para adicionar projetos a um funcionário
                    break;
                case 6:
                    continuar = false; // Encerra o loop do menu e sai do programa
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente."); // Mensagem para opções inválidas
                    break;
            }
        }
    }

    //metodo para adicionar um funcionário de tempo integral a empresa
    static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
    {
        //Solicita e lê o nome do funcionário
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido. Tente novamente.");
            return;
        }

        //Solicita e lê a matrícula do funcionário
        Console.Write("Matrícula: ");
        if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int matricula))
        {
            Console.WriteLine("Matrícula inválida. Tente novamente.");
            return;
        }

        //Solicita e lê o salário mensal do funcionário
        Console.Write("Salário Mensal: ");
        if (!double.TryParse(Console.ReadLine() ?? string.Empty, out double salarioMensal))
        {
            Console.WriteLine("Salário inválido. Tente novamente.");
            return;
        }


        //Cria um objeto FuncionarioTempoIntegral com os dados informados e adiciona a empresa
        FuncionarioTempoIntegral funcionario = new FuncionarioTempoIntegral(nome, matricula, salarioMensal);
        empresa.AdicionarFuncionario(funcionario);
    }
    
    // Método para adicionar um funcionário de meio período a empresa
    static void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
    {
        // Solicita e lê o nome do funcionário
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido. Tente novamente.");
            return;
        }

        //Solicita e lê a matrícula do funcionário
        Console.Write("Matrícula: ");
        if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int matricula))
        {
            Console.WriteLine("Matrícula inválida. Tente novamente.");
            return;
        }

         //Solicita e lê o salário por hora do funcionário
        Console.Write("Salário por Hora: ");
        if (!double.TryParse(Console.ReadLine() ?? string.Empty, out double salarioPorHora))
        {
            Console.WriteLine("Salário inválido. Tente novamente.");
            return;
        }

        //Solicita e lê as horas trabalhadas pelo funcionário
        Console.Write("Horas Trabalhadas: ");
        if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int horasTrabalhadas))
        {
            Console.WriteLine("Número de horas trabalhadas inválido. Tente novamente.");
            return;
        }

         //Cria um objeto FuncionarioMeioPeriodo com os dados informados e adiciona à empresa
        FuncionarioMeioPeriodo funcionario = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, horasTrabalhadas);
        empresa.AdicionarFuncionario(funcionario);
    }

     //Método para remover um funcionário da empresa
    static void RemoverFuncionario(Empresa empresa)
    {
        //Solicita e lê a matrícula do funcionário a ser removido
        Console.Write("Matrícula do Funcionário a Remover: ");
        if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int matricula))
        {
            Console.WriteLine("Matrícula inválida. Tente novamente.");
            return;
        }
        //Chama o método da classe Empresa para remover o funcionário com a matrícula informada
        empresa.RemoverFuncionario(matricula);
    }

    //Método para adicionar projetos a um funcionário da empresa
    static void AdicionarProjetos(Empresa empresa)
    {   
        //Solicita e lê a matrícula do funcionário
        Console.Write("Matrícula do Funcionário: ");
        if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int matricula))
        {
            Console.WriteLine("Matrícula inválida. Tente novamente.");
            return;
        }

         //Busca o funcionário na lista da empresa com base na matrícula informada
        var funcionario = empresa.Funcionarios.SingleOrDefault(f => f.Matricula == matricula);
        if (funcionario != null)
        {
            //Solicita e lê a quantidade de projetos a serem adicionados
            Console.Write("Quantos projetos deseja adicionar? ");
            if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int qtd))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                return;
            }
            
            //Loop para solicitar e ler o nome de cada projeto a ser adicionado
            for (int i = 0; i < qtd; i++)
            {
                Console.Write($"Nome do Projeto {i + 1}: ");
                string? projeto = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(projeto))
                {
                    funcionario.AdicionarProjeto(projeto); //Chama o método AdicionarProjeto do funcionário encontrado
                }
                else
                {
                    Console.WriteLine("Nome do projeto inválido. Tente novamente.");
                }
            }
        }
        else
        {
            Console.WriteLine("Funcionário não encontrado.");
        }
    }
}


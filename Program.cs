Empresa e1 = new Empresa();
bool sair = false;
while (!sair)
{
    Console.WriteLine("----- Menu ----- ");
    Console.WriteLine("________________________________________________");
    Console.WriteLine("");
    Console.WriteLine("[1] Adicionar um funcionário de tempo integral");
    Console.WriteLine("[2] Adicionar um funcionário de meio período");
    Console.WriteLine("[3] Remover um funcionário");
    Console.WriteLine("[4] Exibir informações de todos os funcionários");
    Console.WriteLine("[5] Adicionar projeto(s) a um funcionário");
    Console.WriteLine("[0] Sair do programa");
    Console.WriteLine("________________________________________________");
    Console.WriteLine("-- Escolha uma das opções --");

    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Nome do funcionario:");
            string nomeFuncInteg = Console.ReadLine();
            Console.WriteLine("Matrícula do funcionário:");
            int matriculaFuncInteg = int.Parse(Console.ReadLine());
            Console.WriteLine("Salário Mensal:");
            double salarioFuncInteg = double.Parse(Console.ReadLine());

            FuncionarioTempoIntegral fti1 = new FuncionarioTempoIntegral(nomeFuncInteg, matriculaFuncInteg, salarioFuncInteg);
            e1.AdicionarFuncionario(fti1);
            Console.WriteLine("O funcionário foi adicionado!");
            break;


        case 2:
            Console.WriteLine("Nome do funcionario:");
            string nomeFMP = Console.ReadLine();
            Console.WriteLine("Matrícula do Funcionário:");
            int matriculaFMP = int.Parse(Console.ReadLine());
            Console.WriteLine("Salário por hora:");
            double salárioHoraFMP = double.Parse(Console.ReadLine());
            Console.WriteLine("Horas Trabalhadas:");
            double horasTrabFMP = double.Parse(Console.ReadLine());

            FuncionarioMeioPeriodo fmp1 = new FuncionarioMeioPeriodo(nomeFMP, matriculaFMP, salárioHoraFMP, horasTrabFMP);
            e1.AdicionarFuncionario(fmp1);
            Console.WriteLine("O funcionário foi adicionado");
            break;


        case 3:
            Console.WriteLine("Digite o número da matrícula do funcionário");
            int matriculaRemovida = int.Parse(Console.ReadLine());
            e1.RemoverFuncionario(matriculaRemovida);
            break;


        case 4:
            Console.WriteLine("--- Quadro de Funcionários ---");
            e1.ExibirFuncionarios();
            break;


        case 5:
            Console.WriteLine("Número da Matrícula do funcionário: ");
            int matriculaFunc = int.Parse(Console.ReadLine());
            e1.AdicionarProjetoAoFuncionario(matriculaFunc);
            break;
        

        case 0:
            Console.WriteLine("Programa encerrado!");
            sair = true;
            break;


    }






}

public class Empresa
{
    public List<Funcionario> funcionarios = new List<Funcionario>();

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }

    public void RemoverFuncionario(int matricula)
    {
        foreach (var funcionario in funcionarios)
        {
            if (funcionario.matricula == matricula)
            {
                funcionarios.Remove(funcionario);
                break;
            }
        }
    }


    public void AdicionarProjetoAoFuncionario(int matricula)
    {
        foreach (var funcionario in funcionarios)
        {
            if (matricula == funcionario.matricula)
            {
                Console.WriteLine("Quantos projetos quer adicionar [1] - Um Projeto | [2] - Mais de um ");
                int numeroDeProj = Convert.ToInt32(Console.ReadLine());
                if (numeroDeProj == 1)
                {
                    Console.WriteLine("Nome do projeto:");
                    string proj = Console.ReadLine();
                    funcionario.AdicionarProjeto(proj);
                }
                else
                {
                    List<string> ProjetosFuncionarios = new List<string>();
                    Console.WriteLine("Digite os nomes dos projetos separados por vírgula:");
                    string input = Console.ReadLine();

                    string[] projetos = input.Split(',');
                    for (int i = 0; i < projetos.Length; i++)
                    {
                        projetos[i] = projetos[i].Trim(); 
                        }
                    ProjetosFuncionarios.AddRange(projetos);
                    funcionario.AdicionarProjeto(ProjetosFuncionarios);
                }
            }

        }
    }


    public void ExibirFuncionarios()
    {
        foreach (var funcionario in funcionarios)
        {
            funcionario.ExibirInfo();
        }
    }


    

}
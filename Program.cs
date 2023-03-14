using ExercicioSuco;


bool sistemaFuncionando = true;

while(sistemaFuncionando)
{
    var opcao = Menu.SelecionarOpcao();
    switch (opcao)
    {
        case 1:
            Repositorio.InserirBebida();
            Console.Clear();
            break;
        case 2:
            Repositorio.AlterarBebida();
            Console.Clear();
            break;
        case 3:
            Repositorio.ExcluirBebida();
            Console.Clear();
            break;
        case 4:
            Repositorio.ListarBebidas();
            Console.Clear();
            break;
        case 5:
            Repositorio.ListarSucos();
            Console.Clear();
            break;
        case 6:
            Repositorio.ListarRefrigerantes();
            Console.Clear();
            break;
        case 7:
            Console.Clear();
            Console.WriteLine("Saindo...");
            Thread.Sleep(1000);
            sistemaFuncionando = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opção com erro, selecione a correta!");
            Thread.Sleep(2000);
            Console.Clear();
            break;
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSuco
{
    public static class Menu
    {
        public static int SelecionarOpcao()
        {
            try {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=");
                Console.WriteLine("* Selecione a opção que deseja realizar: *");
                Console.WriteLine("* 1 - Inserir Bebida                     *");
                Console.WriteLine("* 2 - Alterar Bebida                     *");
                Console.WriteLine("* 3 - Excluir Bebida                     *");
                Console.WriteLine("* 4 - Listar todas as Bebidas            *");
                Console.WriteLine("* 5 - Listar todos os Sucos              *");
                Console.WriteLine("* 6 - Listar todos os Refrigerantes      *");
                Console.WriteLine("* 7 - Sair                               *");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=");
                Console.Write("Opção: ");
                return int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Opção com erro, selecione a correta!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            return SelecionarOpcao();
        }
    }
}

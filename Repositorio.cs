using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSuco
{
    public static class Repositorio
    {
        public static List<Bebida> Bebidas{ get; set; }
        public static List<Suco> Sucos { get; set; }
        public static List<Refrigerante> Refrigerantes { get; set;}

        static Repositorio()
        {
            Bebidas = new List<Bebida>();
            Sucos = new List<Suco>();
            Refrigerantes = new List<Refrigerante>();
        }

        public static void InserirBebida()
        {
            Console.Clear();
            Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
            Console.WriteLine("* Qual tipo de Bebida deseja adicionar? *");
            Console.WriteLine("* 1 - Suco                              *");
            Console.WriteLine("* 2 - Refrigerante                      *");
            Console.WriteLine("* 3 - Outro                             *");
            Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                Console.WriteLine("Qual o Tipo de Embalagem?");
                string TipoCaixa = Console.ReadLine();
                Console.WriteLine("Qual o ID?");
                int Id = int.Parse(Console.ReadLine());
                string Tipo = "Suco";
                Console.WriteLine("Quantos MiliLitros tem?");
                decimal MiliLitro = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Qual a Marca?");
                string NomeBebida = Console.ReadLine();
                Console.WriteLine("Qual o valor?");
                decimal ValorCompra = decimal.Parse(Console.ReadLine());
                Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                Bebida bebida = new Bebida(Id, Tipo, MiliLitro, NomeBebida, ValorCompra);
                Suco suco = new Suco(TipoCaixa, Id, Tipo, MiliLitro, NomeBebida, ValorCompra);
                AdicionarBebida(bebida);
                AdicionarSuco(suco);
            }
            else if (opcao == 2)
            {
                Console.Clear();
                Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                Console.WriteLine("* Qual a Embalagem?                     *");
                Console.WriteLine("* 1 - Vidro                             *");
                Console.WriteLine("* 2 - Garrafa Pet                       *");
                Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                int escolha = int.Parse(Console.ReadLine());
                bool Vidro;
                if (escolha == 1)
                {
                    Vidro = true;
                }
                else
                {
                    Vidro = false;
                }
                Console.Clear();
                Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                Console.WriteLine("Qual o ID?");
                int Id = int.Parse(Console.ReadLine());
                string Tipo = "Refrigerante";
                Console.WriteLine("Quantos MiliLitros tem?");
                decimal MiliLitro = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Qual a Marca?");
                string NomeBebida = Console.ReadLine();
                Console.WriteLine("Qual o valor?");
                decimal ValorCompra = decimal.Parse(Console.ReadLine());
                Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                Bebida bebida = new Bebida(Id, Tipo, MiliLitro, NomeBebida, ValorCompra);
                Refrigerante refrigerante = new Refrigerante(Vidro, Id, Tipo, MiliLitro, NomeBebida, ValorCompra);
                AdicionarBebida(bebida);
                AdicionarRefrigerante(refrigerante);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                Console.WriteLine("Qual o ID?");
                int Id = int.Parse(Console.ReadLine());
                string Tipo = "Refrigerante";
                Console.WriteLine("Quantos MiliLitros tem?");
                decimal MiliLitro = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Qual a Marca?");
                string NomeBebida = Console.ReadLine();
                Console.WriteLine("Qual o valor?");
                decimal ValorCompra = decimal.Parse(Console.ReadLine());
                Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                Bebida bebida = new Bebida(Id, Tipo, MiliLitro, NomeBebida, ValorCompra);
                AdicionarBebida(bebida);
            }
        }

        public static void AdicionarBebida(Bebida bebida)
        {
            Bebidas.Add(bebida);
        }
        public static void AdicionarSuco(Suco suco)
        {
            Sucos.Add(suco);
        }
        public static void AdicionarRefrigerante(Refrigerante refrigerante)
        {
            Refrigerantes.Add(refrigerante);
        }


        public static void ExcluirBebida()
        {
            Console.Clear();
            Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
            Console.WriteLine("* Qual ID da bebida que deseja excluir? *");
            int IdExcluir = int.Parse(Console.ReadLine());
            bool existe = Bebidas.Exists(x => x.Id == IdExcluir);
            bool existeSuco = Sucos.Exists(x => x.Id == IdExcluir);
            bool existeRefri = Refrigerantes.Exists(x => x.Id == IdExcluir);
            if (existe)
            {
                Bebidas.RemoveAll(x => x.Id == IdExcluir);
                if(existeSuco)
                {
                    Sucos.RemoveAll(x => x.Id == IdExcluir);
                }
                else if (existeRefri)
                {
                    Refrigerantes.RemoveAll(x => x.Id == IdExcluir);
                }
                Console.WriteLine("*           Bebida Excluida !           *");
                Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
            }
            if (!existe)
            {
                Console.WriteLine("Id não encontrado, prosseguindo com o sistema");
            }
        }
        
        public static void ListarBebidas()
        {
            Console.Clear();
            if (Bebidas.Count > 0)
            {
                Console.WriteLine("Mostrando lista de bebidas a seguir");
                foreach (var bebida in Bebidas)
                {
                    Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                    Console.WriteLine($"* O Id da bebida é {bebida.Id} *");
                    Console.WriteLine($"* A bebida em questão é um {bebida.Tipo} *");
                    Console.WriteLine($"* Possui {bebida.MiliLitro} MiliLitros *");
                    Console.WriteLine($"* A marca é {bebida.NomeBebida} *");
                    Console.WriteLine($"* O preço é {bebida.ValorCompra} *");
                    Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                    Console.WriteLine("\n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Não existem elementos na lista!");
                Console.ReadKey();
            }
        }

        public static void ListarSucos()
        {
            Console.Clear();
            if (Sucos.Count > 0)
            {
                Console.WriteLine("Mostrando lista de Sucos a seguir");
                foreach (var suco in Sucos)
                {
                    Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                    Console.WriteLine($"* O Id do Suco é {suco.Id} *");
                    Console.WriteLine($"* A bebida em questão é um {suco.Tipo} *");
                    Console.WriteLine($"* O tipo da caixa é {suco.TipoCaixa} *");
                    Console.WriteLine($"* Possui {suco.MiliLitro} MiliLitros *");
                    Console.WriteLine($"* A marca do Suco é {suco.NomeBebida} *");
                    Console.WriteLine($"* O preço é {suco.ValorCompra} *");
                    Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                    Console.WriteLine("\n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Não existem elementos na lista!");
                Console.ReadKey();
            }
        }

        public static void ListarRefrigerantes()
        {
            Console.Clear();
            if (Refrigerantes.Count > 0)
            {
                Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-");
                Console.WriteLine("* Mostrando lista de Refrigerantes a seguir *");
                foreach (var refrigerante in Refrigerantes)
                {
                    Console.WriteLine($"* O Id da bebida é {refrigerante.Id} *");
                    if (refrigerante.Vidro == true)
                    {
                        Console.WriteLine("* A embalagem é de vidro *");
                    }
                    else
                    {
                        Console.WriteLine("* A embalagem é de garrafa Pet *");
                    }
                    Console.WriteLine($"* A bebida em questão é um {refrigerante.Tipo} *");
                    Console.WriteLine($"* Possui {refrigerante.MiliLitro} MiliLitros *");
                    Console.WriteLine($"* A marca do Refrigerante é {refrigerante.NomeBebida} *");
                    Console.WriteLine($"* O preço para compra é {refrigerante.ValorCompra} *");
                    Console.WriteLine("\n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Não existem elementos na lista!");
                Console.ReadKey();
            }
        }

        public static void AlterarBebida()
        {
            Console.Clear();
            Console.WriteLine("Qual Id da Bebida que deseja alterar?");
            int idSelecionado = int.Parse(Console.ReadLine());
            int bebida = Bebidas.FindIndex(x => x.Id == idSelecionado);
            if (bebida != -1)
            {
                Console.WriteLine($"Qual o novo tipo da Bebida de Id {idSelecionado}?");
                Bebidas[bebida].Tipo = Console.ReadLine();
                Console.WriteLine($"\nQual o novo MiliLitro para a Bebida de Id {idSelecionado}?");
                Bebidas[bebida].MiliLitro = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"\nQual o novo nome para a Bebida de Id {idSelecionado}?");
                Bebidas[bebida].NomeBebida = Console.ReadLine();
                Console.WriteLine($"\nQual o novo valor para a Bebida de Id {idSelecionado}?");
                Bebidas[bebida].ValorCompra = decimal.Parse(Console.ReadLine()) ;
            }
        }
    }
}

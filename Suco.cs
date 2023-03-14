using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSuco
{
    public class Suco : Bebida
    {
        public string TipoCaixa { get; set; }

        public Suco(string TipoCaixa, int Id, string Tipo, decimal MiliLitro, string NomeBebida, decimal ValorCompra) : base(Id, Tipo, MiliLitro, NomeBebida, ValorCompra)
        {
            this.TipoCaixa = TipoCaixa;
            this.Id = Id;
            this.Tipo = Tipo;
            this.MiliLitro = MiliLitro;
            this.NomeBebida = NomeBebida;
            this.ValorCompra = ValorCompra;
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"O produto id {Id} é um suco é do tipo {TipoCaixa}  com quantidade de MiliLitros {MiliLitro}");
        }
    }
}

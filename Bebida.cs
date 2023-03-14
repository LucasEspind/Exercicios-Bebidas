using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSuco
{
    public class Bebida
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal MiliLitro { get; set; }
        public string NomeBebida { get; set; }
        public decimal ValorCompra { get; set; }

        public Bebida(int Id, string Tipo, decimal MiliLitro, string NomeBebida, decimal ValorCompra) {
            this.Id = Id;
            this.Tipo = Tipo;
            this.MiliLitro = MiliLitro;
            this.NomeBebida = NomeBebida;
            this.ValorCompra = ValorCompra;
        }

        public void Comprar()
        {
            Console.WriteLine($"Valor da compra do produto id {Id} alterado para {ValorCompra}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSuco
{
    public class Refrigerante : Bebida
    {
        public bool Vidro { get; set; }
        public Refrigerante(bool Vidro, int Id, string Tipo, decimal MiliLitro, string NomeBebida, decimal ValorCompra) : base(Id, Tipo, MiliLitro, NomeBebida, ValorCompra) 
        {   
            this.Vidro = Vidro;
            this.Id = Id;
            this.Tipo = Tipo;
            this.MiliLitro = MiliLitro;
            this.NomeBebida = NomeBebida;
            this.ValorCompra = ValorCompra;
        }

        public void ImprimirDados()
        {
            if (Vidro)
            {
                Console.WriteLine($"O produto id {Id} com nome {NomeBebida}é um refrigerante MiliLitros {MiliLitro} é um vidro");
            }
            else {
                Console.WriteLine($"O produto id {Id} com nome {NomeBebida}é um refrigerante MiliLitros {MiliLitro} é uma garrafa pet");
            }
        }
           
    }
}

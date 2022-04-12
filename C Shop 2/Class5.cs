using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop_2
{
    internal class CiboInScatola : Prodotto
    {
        private double peso;

        public CiboInScatola(string Nomecibo, string Descrizionecibo, double Prezzocibo, int iva, int peso) : base(Nomecibo, Descrizionecibo, Prezzocibo, iva)
        {
            this.peso = peso;
        }
        public override void NomeEsteso()
        {
            Console.WriteLine("Il codice esteso del prodotto è: " + base.CodicePadding() + " - " + base.nome + " - " + base.GetPrezzo() + "$  peso: " + peso + " g");
        }
    }
}

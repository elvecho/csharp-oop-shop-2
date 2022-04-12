using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop_2
{
    internal class SacchettoDiFrutta : Prodotto
    {
        private int quantità;
        private int peso;

        public SacchettoDiFrutta(string NomeFrutta, string DescrizioneFrutta, double PrezzoFrutta, int iva, int quantità, int peso) : base(NomeFrutta, DescrizioneFrutta, PrezzoFrutta, iva)
        {
            this.quantità = quantità;
            this.peso = peso;

        }
        public int GetQuantita()
        {
            return quantità;
        }
        public int Getpeso()
        {
            return peso;
        }
        public override void NomeEsteso()
        {
            Console.WriteLine("Il codice esteso del prodotto è: " + base.CodicePadding() + " - " + base.nome + " - " + peso + " grammi" + "la quantità è di: " + quantità );
        }
//Metodi
public void AggiungiFrutta(int quantitàdifruttaDaAggiungere)
        {
            if(quantità + quantitàdifruttaDaAggiungere > 5)
            {
                Console.WriteLine("il massimo è 5 pezzi stai aggiungendo troppo");
            }
            else
            {
               quantità =  quantità + quantitàdifruttaDaAggiungere;
                Console.WriteLine("la quantità di frutta ora è: " + quantità);

            }
          
        }
        public void togliFrutta(int quantitàDiFruttaDaTogliere)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop_2
{
    internal class Prodotto
    {
        private int codice;
        private protected string nome;
        private string descrizione;
        private double prezzo;
        private double iva;

        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
            Random random = new Random();
            codice = random.Next(100000000);
        }
        //getter e setter

        public string GetCodicePadding()
        {
           string codiceP = CodicePadding();
            return codiceP;

        }
        public string GetDescrizione()
        {
            return descrizione;
        }
        public double GetPrezzo()
        {
            return prezzo;
        }
        public double GetIva()
        {
            return iva;
        }
        public void SetPrezzo(double nuovoPrezzo)
        {
            if (nuovoPrezzo < 0)
            {
                return;
            }
            else
            {
                prezzo = nuovoPrezzo;
            }
        }
        public void SetDescrizione(string nuovaDescrizione)
        {
            descrizione = nuovaDescrizione;
        }
        public void SetNome(string nuovoNome)
        {
            nome = nuovoNome;
        }
        public int GetCodice()
        {
           return codice;
        }
        //Metodi
        public virtual void NomeEsteso()
        {
            Console.WriteLine("Il codice esteso del prodotto è: " + CodicePadding() + " - " + nome);
        }
        public string CodicePadding()
        {
            string CodiceString = codice.ToString();
            char zero = '0';
            return CodiceString.PadLeft(8, zero);
        }
    }
}

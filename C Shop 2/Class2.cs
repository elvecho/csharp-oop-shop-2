using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop_2
{
    internal class Acqua : Prodotto
    {
      private double litri;
        private string sorgente;
        private int Ph;

        public Acqua(string nomeAcqua,string descrizioneAcqua, double PrezzoAcqua, int iva, double litri, string sorgente, int Ph) : base( nomeAcqua, descrizioneAcqua, PrezzoAcqua, iva)
        {
            this.Ph = Ph;
            this.sorgente = sorgente;
            this.litri = litri;
        }
        //Metodi
        public override void NomeEsteso()
        {
            Console.WriteLine("Il codice esteso del prodotto è: " + base.CodicePadding() + " - " + base.nome + " - " + litri + " litri" + "si trova " + sorgente + "ph: " + Ph);
        }
        public  double ConvertiInGalloni(double litri)
        {
            litri = litri * 3.785;
            return litri;
        }
        public void Bevi(double LitriDaBere)
        {
            if (litri - LitriDaBere > 0)
            {
                litri = litri - LitriDaBere;
                Console.WriteLine("ho bevuto ");
                Console.WriteLine("ti rimangono: " + litri);
            }
            else
            {
                Console.WriteLine("ho finito la bottiglia");
                litri = 0;
            }
        }
        public void riempi(double litriDaAggiungere)
        {
            if(( litri + litriDaAggiungere) > 1.5)
            {
                Console.WriteLine(" la stai riempendo troppo");
            }
            else
            {
                litri = litri + litriDaAggiungere;
                Console.WriteLine("la bottiglia è stata riempita");
                Console.WriteLine(litri + "litri");
            }
            


 
        }
        public void svuota()
        {
            if (litri > 0)
            {
                litri = 0;
                Console.WriteLine("la bottiglia è stata svuotata");
                Console.WriteLine(litri);
            }
            else
            {
                Console.WriteLine("la bottiglia è già vuota");
            }
        }
    }
}

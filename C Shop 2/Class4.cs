using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop_2
{
    internal class Elettrodomestico : Prodotto
    {
        private string Marca;
        private int Voltaggio;
        private bool accenditi;
        private int PercentualeBatteria;


        public Elettrodomestico(string NomeElet, string DescrizioneElet, double PrezzoElet, int iva, string Marca, int Voltaggio, int PercentualeBatteria) : base(NomeElet, DescrizioneElet, PrezzoElet, iva)
        {
            this.Marca = Marca; 
            this.Voltaggio = Voltaggio;
            this.PercentualeBatteria = PercentualeBatteria; 
        }
        public string GetMarca()
        {
            return Marca;
        }
        public int GetVoltaggio()
        {
            return Voltaggio;
        }
        public bool AccendiElettrodomestico()
        {
            Console.WriteLine("rumore di eletrodomestico acceso");
            return accenditi = true;
           
        }
        public bool SpegniElettrodomestico()
        {
            return accenditi = false;
        }

        public void UsaElettrodomestico(int OreDiUtilizzo)
        {
            
            if (OreDiUtilizzo >= 5)
            {
                Console.WriteLine("stai utilizzando l elettrodomestico");
                
                PercentualeBatteria = 0;
                Console.WriteLine("rumore di eletrodomestico che si spegne.. devi ricaricare percentuale batteria: " + PercentualeBatteria);

            }if(PercentualeBatteria == 0)
            {
                Console.WriteLine("l elettrodomestico è scarico");
            }
            else
            {
                Console.WriteLine("stai utilizzando l elettrodomestico");
                PercentualeBatteria = PercentualeBatteria - (20 * OreDiUtilizzo);
                    Console.WriteLine("la tua percentuale batteria: " + PercentualeBatteria + "%");
            }
        }
        public void CaricaElettrodomestico(int Oredicarica)
        {
         
            PercentualeBatteria = PercentualeBatteria + ( 20 * Oredicarica);
            if (PercentualeBatteria >= 100)
            {
                PercentualeBatteria = 100;
                

                Console.WriteLine("la carica è andata a buon fine la tua percentuale di carica è: " + PercentualeBatteria + "%");
                Console.WriteLine("la carica è al massimo");
            }
        }
    }
}

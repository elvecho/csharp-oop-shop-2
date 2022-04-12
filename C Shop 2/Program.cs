// See https://aka.ms/new-console-template for more information
using C_Shop_2;

Acqua acquaLete = new Acqua("lete", "buonaLacqua",1, 22, 1.5, " fronte campano del Matese ", 6);
acquaLete.NomeEsteso();
acquaLete.Bevi(1);
acquaLete.svuota();
acquaLete.riempi(1.5);
Console.WriteLine(acquaLete.ConvertiInGalloni(1.5));

SacchettoDiFrutta fruttaMista = new SacchettoDiFrutta("frutta", " buonalafrutta", 2, 22, 5, 1000);
fruttaMista.NomeEsteso();








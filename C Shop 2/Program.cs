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
fruttaMista.togliFrutta(4);
fruttaMista.AggiungiFrutta(1);

Elettrodomestico aspirapolvere = new Elettrodomestico("aspirapolvere", "buono per aspirare", 250, 22, "Dyson", 2000, 100);
aspirapolvere.AccendiElettrodomestico();
aspirapolvere.UsaElettrodomestico(6);
aspirapolvere.UsaElettrodomestico(1);
aspirapolvere.CaricaElettrodomestico(3);
aspirapolvere.CaricaElettrodomestico(3);
aspirapolvere.UsaElettrodomestico(3);


CiboInScatola fagioli = new CiboInScatola("fagioli", " fagioli", 3, 10, 300);
fagioli.NomeEsteso();






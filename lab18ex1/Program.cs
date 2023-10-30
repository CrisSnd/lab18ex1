// See https://aka.ms/new-console-template for more information
using lab18ex1;
using lab18ex1.Models;


/*Un autovehicul este caracterizat de urmatoarele proprietati
• Id:int
• Nume
• Producator
• Un numar variabil de chei (de la una la oricate)
• O carte tehnica
• Cartea tehnica va avea urmatoarele:
• Id:int
• Capacitate cilindrica :int
• An de fabricatie :int
• Serie de sasiu: string
• Producatorul va avea
• Id:int
• Nume
• Adresa:string
• O cheie va avea urmatoarele caracteristici
• Id (int)
• Cod de acces : Guid unic.

• Creeati modelul, Adaugati DB, populati DB
• Scrieti urmatoarele metode
• Adaugare autovehicul
• Implica adaugarea carei entitati?
• Adaugare producator
• Adaugare cheie unui autovehicul
• Inlocuire carte tehnica
• Stergere autovehicul
• Stergere producator
• Stergere cheie
• Determinati relatiile necesare
• Determinati delete propagation-ul necesar pentru fiecare
relatie in parte*/



//Console.WriteLine();

//DataLayerSingleton.Instance.Seed();

Autovehicul jetta = DataLayerSingleton.Instance.AdaugaAutovehicul("Jetta", 1);

var dacia = DataLayerSingleton.Instance.AdaugaProducator("Dacia", "Mioveni");

DataLayerSingleton.Instance.AdaugaCheieLaAutovehicul(Guid.NewGuid(),1);
DataLayerSingleton.Instance.StergeAutovehicul(1);

Console.WriteLine("Hello, World!");
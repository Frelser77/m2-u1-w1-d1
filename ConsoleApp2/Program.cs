using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animale animaleDomestico2 = new Animale
            {
                Name = "Felix",
                Tipo = "Gatto, Siamese",
                Age = 7
            };

            Veicolo veicoloAziendale = new Veicolo
            {
                Name = "Fiorino 2600",
                Description = "Veicolo aziendale per l'accompagnamento..."
            };

            int kmAttualiDipendente = 12500;

            Dipendente dipendente = new Dipendente
            {
                Name = "Giovanni",
                Entrata = DateTime.Now,
                Uscita = DateTime.Now.AddHours(6),
                AnimaleDomestico2 = animaleDomestico2,
                VeicoloAziendale= veicoloAziendale
            };

            Animale animaleDomestico = new Animale
            {
                Name = "Lyla",
                Tipo = "Cane, bassatto",
                Age = 9
            };

            Veicolo veicoloPrivato = new Veicolo
            {
                Name = "Mustang 4000",
                Description = "Macchina sportiva con prestazione elevatissime..."
            };

            Atleta atleta = new Atleta
            {
                Name = "Bruno",
                DayAllenamenti = 1787,
                AnimaleDomestico = animaleDomestico,
                VeicoloPrivato = veicoloPrivato
            };

            int kmAttualiPrivato = 2000;

            Console.WriteLine("DIPENDENTE");
            Console.WriteLine("\n");
            Console.WriteLine($"Nome del dipendente: {dipendente.Name}");
            Console.WriteLine($"Entrata del : {dipendente.Entrata}");
            Console.WriteLine($"Uscita del : {dipendente.Uscita}");
            Console.WriteLine($"Animale Domestico: {dipendente.AnimaleDomestico2.Name}, Tipo: {dipendente.AnimaleDomestico2.Tipo}, Etá: {dipendente.AnimaleDomestico2.Age}");
            Console.WriteLine($"Veicolo Aziendale: {dipendente.VeicoloAziendale.Name}, Descrizione: {dipendente.VeicoloAziendale.Description}");
            Console.WriteLine(dipendente.VeicoloAziendale.KmTagliando(kmAttualiDipendente));
            Console.WriteLine("\n");
            Console.WriteLine("ATLETA");
            Console.WriteLine("\n");
            Console.WriteLine($"Nome dell'Atleta: {atleta.Name}");
            Console.WriteLine($"Si allena da: {atleta.DayAllenamenti} giorni");
            Console.WriteLine($"Animale Domestico: {atleta.AnimaleDomestico.Name}, Tipo: {atleta.AnimaleDomestico.Tipo}, Etá: {atleta.AnimaleDomestico.Age}");
            Console.WriteLine($"Veicolo Privato: {atleta.VeicoloPrivato.Name}, Descrizione: {atleta.VeicoloPrivato.Description}");
            Console.WriteLine(atleta.VeicoloPrivato.KmTagliando(kmAttualiPrivato));

            Console.ReadLine();
        }
    }
}

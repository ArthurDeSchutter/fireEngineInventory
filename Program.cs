using System;
using System.Collections.Generic;

namespace fireengineinventoryv2
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemlist = new List<fireEngineItem>();
            itemlist.Add(new fireEngineItem("Vaste radio type Sepura SRG3900+gateway ", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("GPS Garmin ", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Ipad CRS", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Rode map boorddocumenten", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Kaft Actiekaart hogedruk aardgas+instructiefiches", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Verkeers Kazuifel signalisatie THV (C-B) ", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Mobiele radio type Sepura TP8X + lader ", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Streamlight - zaklampen in lader", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Warmtebeeldcamera Dräger CF 9000", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Zuurstof Explosiemeter Dräger X-AM 2500", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Pomp explosiemeter ", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Sleutel paaltjes", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Sleutelkluis + sleutel ", "Cabine vooraan "));
            itemlist.Add(new fireEngineItem("Ademluchttoestel PSS 7000 ", "Cabine achter "));
            itemlist.Add(new fireEngineItem("Ademluchtmasker", "Cabine achter "));
            itemlist.Add(new fireEngineItem("Mobiele radio Sepura SC20 (DMO)+mike+lader ", "Cabine achter "));
            itemlist.Add(new fireEngineItem("Signalisatietoorts", "Cabine achter "));
            itemlist.Add(new fireEngineItem("Tijdsregistratie bord Dräger Regis 300", "Cabine achter "));
            itemlist.Add(new fireEngineItem("Rol rode zakken vervuilde maskers ", "Cabine achter "));
            itemlist.Add(new fireEngineItem("Bak reserve PBM", "Cabine achter "));
            itemlist.Add(new fireEngineItem("Beveilgerstas THV", "Cabine achter "));
            itemlist.Add(new fireEngineItem("Redding Masker Dräger", "Cabine achter "));
            itemlist.Add(new fireEngineItem("Reserve ademluchtfles 6.8 l composiet", "Cabine achter "));
            itemlist.Add(new fireEngineItem("Bak ZA1H CA 1.2 drank", "Cabine achter "));
            itemlist.Add(new fireEngineItem("EHBO-set voertuig", "Cabine achter "));


            itemlist.Add(new fireEngineItem(" isolerende stok", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Wervelplank", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Verkeerskegel 50 cm set BIOW Zone Rand", "Kast 1 "));
            itemlist.Add(new fireEngineItem(" Afspanlint-lijkzak", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Gereedschap elektra", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Deuropenerset", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Gele synchroniseerbare LED-lamp set BIOW", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Isolatie Handschoenen ", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Gereedschapskoffer", "Kast 1 "));
            itemlist.Add(new fireEngineItem(" Breekhamer+beitels+verlengdraad", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Bidon absorberende korrels ", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Lekafdichting", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Spanbanden + ratels ", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Kabelhaspel 230V 25 meter", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Reddingsboei", "Kast 1 "));
            itemlist.Add(new fireEngineItem("Elektrogroep", "Kast 1 "));


            itemlist.Add(new fireEngineItem("Persslang ∅ 70 mm ", "Kast 2 "));
            itemlist.Add(new fireEngineItem("Peli ledlamp ", "Kast 2 "));
            itemlist.Add(new fireEngineItem("Afdekzeilen", "Kast 2 "));
            itemlist.Add(new fireEngineItem("Lekopvang", "Kast 2 "));
            itemlist.Add(new fireEngineItem("IGS set", "Kast 2 "));
            itemlist.Add(new fireEngineItem("decontaminatie", "Kast 2 "));
            itemlist.Add(new fireEngineItem("Waadpakken", "Kast 2 "));
            itemlist.Add(new fireEngineItem("Persslang ∅ 110mm ", "Kast 3 "));
            itemlist.Add(new fireEngineItem("Hogedrukhaspel 80 m met straalpijp/noodsleutel ", "Kast 3 "));
            itemlist.Add(new fireEngineItem("Elektrische overdrukventilator ", "Kast 3 "));
            itemlist.Add(new fireEngineItem("Rioolafdichtingsmat", "Kast 3 "));
            itemlist.Add(new fireEngineItem("Lekklem", "Kast 3 "));
            itemlist.Add(new fireEngineItem("Draagbare watermonitor met bandlus Ø 70mm ", "Kast 3 "));
            itemlist.Add(new fireEngineItem("Schouwbrandmaterieel", "Kast 3 "));
            itemlist.Add(new fireEngineItem("Dompelpomp+ bochtbeschermer ", "Kast 3 "));
            itemlist.Add(new fireEngineItem("Telescopische ladder", "Kast 3 "));
            itemlist.Add(new fireEngineItem("Zigzag aanvalslijn 3 x 20m Ø 70 mm met verdeelstuk", "Kast 3 "));
           
            
            itemlist.Add(new fireEngineItem("Broekstuk", "Kast 4 "));
            itemlist.Add(new fireEngineItem("Overgangsstuk DSP ∅ 70 mm → Gardena koppeling", "Kast 4 "));
            itemlist.Add(new fireEngineItem("Rioolrat", "Kast 4 "));
            itemlist.Add(new fireEngineItem("zuigkorf", "Kast 4 "));
            itemlist.Add(new fireEngineItem(" afsluitkranen ø 70mm", "Kast 4 "));
            itemlist.Add(new fireEngineItem("Licht Toorts", "Kast 4 "));
            itemlist.Add(new fireEngineItem("Standpijpsleutel ", "Kast 4 "));
            itemlist.Add(new fireEngineItem("Standpijp", "Kast 4 "));


            itemlist.Add(new fireEngineItem("Reactieboog ∅ 70mm ", "Kast 5 "));
            itemlist.Add(new fireEngineItem("Straalpijp ∅ 70 mm", "Kast 5 "));
            itemlist.Add(new fireEngineItem("Drieverdeelstuk 2x ∅ 45mm - 1x ∅ 70 mm", "Kast 5 "));
            itemlist.Add(new fireEngineItem("O-bundel ∅ 45 mm (groen) + G-force straalpijp", "Kast 5 "));
            itemlist.Add(new fireEngineItem("casette 2x ∅ 70mm", "Kast 5 "));
            itemlist.Add(new fireEngineItem("Bovengrondse hydrantsleutel ", "Kast 5 "));
            itemlist.Add(new fireEngineItem("Verloopstuk ∅ 110 mm → ∅ 70 mm", "Kast 5 "));
            itemlist.Add(new fireEngineItem("Straalpijp ∅ 45 mm", "Kast 5 "));


            itemlist.Add(new fireEngineItem("Zeil voor materieeldepot THV", "Kast 6"));
            itemlist.Add(new fireEngineItem("Airbagbeschermhoes", "Kast 6"));
            itemlist.Add(new fireEngineItem("Gordelsnijder", "Kast 6"));
            itemlist.Add(new fireEngineItem("Mini koevoet", "Kast 6"));
            itemlist.Add(new fireEngineItem("Window-punch", "Kast 6"));
            itemlist.Add(new fireEngineItem("Glasmaster", "Kast 6"));
            itemlist.Add(new fireEngineItem("Ramsteun resqtec ", "Kast 6"));
            itemlist.Add(new fireEngineItem("Flexi beschermplaat THV", "Kast 6"));
            itemlist.Add(new fireEngineItem("Zeeppatronen", "Kast 6"));
            itemlist.Add(new fireEngineItem("Zeepstraalpijp", "Kast 6"));
            itemlist.Add(new fireEngineItem("Combi schuimstraalpijp type S2 ", "Kast 6"));
            itemlist.Add(new fireEngineItem("Persslang ∅ 45 mm 5 meter voor schuiminzet ", "Kast 6"));
            itemlist.Add(new fireEngineItem("Tussenmenger schuim ∅ 45 type Z2 ", "Kast 6"));
            itemlist.Add(new fireEngineItem("Aanzuigslang schuimvormend middel ", "Kast 6"));
            itemlist.Add(new fireEngineItem("Hydraulische draagbare groep Holmatro ", "Kast 6"));


            itemlist.Add(new fireEngineItem("Hydraulische slangen ", "Kast 7 DRAAIDEUR voorkant"));
            itemlist.Add(new fireEngineItem("Pens baar ", "Kast 7 DRAAIDEUR voorkant"));
            itemlist.Add(new fireEngineItem("Halligan tool brand", "Kast 7 DRAAIDEUR voorkant"));
            itemlist.Add(new fireEngineItem("Hydraulische ram", "Kast 7 DRAAIDEUR voorkant"));
            itemlist.Add(new fireEngineItem("Ramsteun Holmatro", "Kast 7 DRAAIDEUR voorkant"));
            itemlist.Add(new fireEngineItem("Hydraulische spreider", "Kast 7 DRAAIDEUR voorkant"));
            itemlist.Add(new fireEngineItem("Hydraulische schaar", "Kast 7 DRAAIDEUR voorkant"));
            itemlist.Add(new fireEngineItem("Hydraulische minischaar", "Kast 7 DRAAIDEUR voorkant"));
            itemlist.Add(new fireEngineItem("Grote koevoet", "Kast 7 DRAAIDEUR achterkant"));
            itemlist.Add(new fireEngineItem("Kleine bijl ", "Kast 7 DRAAIDEUR achterkant"));
            itemlist.Add(new fireEngineItem("Grote bijl ", "Kast 7 DRAAIDEUR achterkant"));
            itemlist.Add(new fireEngineItem("Gassleutel platbek ", "Kast 7 DRAAIDEUR achterkant"));
            itemlist.Add(new fireEngineItem("Handzaag", "Kast 7 DRAAIDEUR achterkant"));
            itemlist.Add(new fireEngineItem("Hydraulische handpomp", "Kast 7 DRAAIDEUR achterkant"));
            itemlist.Add(new fireEngineItem("Deuropener met hydraulische slang", "Kast 7 DRAAIDEUR achterkant"));
            itemlist.Add(new fireEngineItem("Voorhamer", "Kast 7 DRAAIDEUR achterkant"));
            itemlist.Add(new fireEngineItem("Hefkussens Sava", "Kast 7 DRAAIDEUR achterkant"));
            itemlist.Add(new fireEngineItem("Spade", "Kast 7"));
            itemlist.Add(new fireEngineItem("Schop", "Kast 7"));
            itemlist.Add(new fireEngineItem("Borstel", "Kast 7"));
            itemlist.Add(new fireEngineItem("Riek", "Kast 7"));
            itemlist.Add(new fireEngineItem("Velhevel groot", "Kast 7"));
            itemlist.Add(new fireEngineItem("Boogzaag", "Kast 7"));
            itemlist.Add(new fireEngineItem("Wielkeggen", "Kast 7"));
            itemlist.Add(new fireEngineItem("Touwen", "Kast 7"));
            itemlist.Add(new fireEngineItem("Reddingsvesten", "Kast 7"));
            itemlist.Add(new fireEngineItem("Elektrisch gereedschap", "Kast 7"));
            itemlist.Add(new fireEngineItem("V-strut systeem in zak + hulpstuk ", "Kast 7"));
            itemlist.Add(new fireEngineItem("Toebehoren hefkussens", "Kast 7"));
            itemlist.Add(new fireEngineItem("Stabilisatieblokken’", "Kast 7"));
            itemlist.Add(new fireEngineItem("Reddingszaag Stihl ", "Kast 7"));
            itemlist.Add(new fireEngineItem("Motorkettingzaag Stihl/kleine velhevel", "Kast 7"));
            itemlist.Add(new fireEngineItem("Jerrycan normaal benzine ", "Kast 7"));
            itemlist.Add(new fireEngineItem("Blusdeken", "Kast 7"));
            Console.WriteLine("press space to see the location of the item");
            Console.WriteLine("press enter to get the next item");
            Console.ReadKey();

            Random rnd = new Random();
            while (true)
            {
                int r = rnd.Next(itemlist.Count);
                Console.WriteLine(itemlist[r].item);
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine($"{itemlist[r].place}");
                    Console.ReadKey();
                }
                itemlist.Remove(itemlist[r]);
            }
        }
    }
}

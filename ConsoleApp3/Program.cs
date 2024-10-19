using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {

        // Skapar en lista för parkerings garaget
        string[] parkingGarage = new string[100];
        for (int i = 0; i < parkingGarage.Length; i++)
        {
            parkingGarage[i] = ""; // fyller listan med tomma strängar
        }

        while (true)
        {
            //rensar terminal från tidigare utskrift
            Console.Clear();

            // Skriver ut ASCII text för rubriken
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
  _____  _____            _____ _    _ ______    _____        _____  _  _______ _   _  _____         __ 
 |  __ \|  __ \     /\   / ____| |  | |  ____|  |  __ \ /\   |  __ \| |/ /_   _| \ | |/ ____|       /_ |
 | |__) | |__) |   /  \ | |  __| |  | | |__     | |__) /  \  | |__) | ' /  | | |  \| | |  __   __   _| |
 |  ___/|  _  /   / /\ \| | |_ | |  | |  __|    |  ___/ /\ \ |  _  /|  <   | | | . ` | | |_ |  \ \ / / |
 | |    | | \ \  / ____ \ |__| | |__| | |____   | |  / ____ \| | \ \| . \ _| |_| |\  | |__| |   \ V /| |
 |_|    |_|  \_\/_/    \_\_____|\____/|______|  |_| /_/    \_\_|  \_\_|\_\_____|_| \_|\_____|    \_/ |_|
                                                                                                       
                                                                                                      
                                                                                                  
                                                                                                  
            ");
            Console.ResetColor();

            // Grundläggande parkering system information
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Välkommen till Prague Parking ");
            Console.WriteLine("Antal parkeringsplatser: 100");
            Console.WriteLine("Timpris för bil: 20,00 kr");
            Console.WriteLine("Timpris för motorcykel: 10,00 kr\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Prague Parking System");
            Console.WriteLine("1. Parkera Fordon");
            Console.WriteLine("2. Hämta Fordon");
            Console.WriteLine("3. Flytta Fordon");
            Console.WriteLine("4. Sök Fordon på Reg nr");
            Console.WriteLine("5. Visa aktuell parkerings vy");
            Console.WriteLine("6. Avsluta");
            Console.Write("Välj ett alternativ: ");
            string choice = Console.ReadLine();

            //Valde Swich istället för If sats då det ser renare ut
            switch (choice)
            {
                case "1":
                    ParkVehicle(parkingGarage);
                    break;
                case "2":
                    RetrieveVehicle(parkingGarage);
                    break;
                case "3":
                    MoveVehicle(parkingGarage);
                    break;
                case "4":
                    SearchVehicle(parkingGarage);
                    break;
                case "5":
                    ViewParkingStatus(parkingGarage);
                    break;
                case "6":
                    return; // Avsluta programmet
                default:
                    Console.WriteLine("Ogiltigt val, Försök igen.");
                    break;
            }
            Console.WriteLine("Tryck enter för att fortsätta...");
            Console.ReadLine();
        }
    }

    static void ParkVehicle(string[] garage)
    {
        Console.Write("Ange fordonstyp (BIL/MC): ");
        string vehicleType = Console.ReadLine().ToUpper();

        if (vehicleType != "BIL" && vehicleType != "MC")
        {
            Console.WriteLine("Fel Fordonstyp.");
            return;
        }
 
        Console.WriteLine("Det ska vara 1-2 bokstäver, 1-4 siffror, följt av 0-2 bokstäver  ");
        Console.Write("Ange registreringsnummer: ");
        string registration = Console.ReadLine();

        // Regex för att kontrollera formatet
        string pattern = @"^[A-Za-z]{1,2}[0-9]{1,4}[A-Za-z]{0,2}$";

        if (!string.IsNullOrWhiteSpace(registration) && registration.Length <= 10 && Regex.IsMatch(registration, pattern))
        {
            Console.WriteLine("Registreringsnumret är giltigt.");
        }
        else
        {
            Console.WriteLine("Fel format på registreringsnumret. Det ska vara 1-2 bokstäver, 1-4 siffror, följt av 0-2 bokstäver.");
            return; 
        }

        // hitta en tom parkeringsplats
        for (int i = 0; i < garage.Length; i++)
        {
            if (string.IsNullOrEmpty(garage[i]))
            {
                garage[i] = $"{vehicleType}#{registration}";
                Console.WriteLine($"Fordon parkerat på ruta {i + 1}.");
                return;
            }
            else if (vehicleType == "MC" && garage[i].StartsWith("MC#"))
            {
                // kontrollera om 2 mc på samma ruta
                if (garage[i].Split('|').Length < 2)
                {
                    garage[i] += $"|{vehicleType}#{registration}";
                    Console.WriteLine($"Motorcykel dubbelparkerad i ruta {i + 1}.");
                    return;
                }
            }
        }

        Console.WriteLine("inga tillgängliga parkeringsplatser.");
    }

    static void RetrieveVehicle(string[] garage)
    {
        Console.Write("ange reg nr för att hämta fordon: ");
        string registration = Console.ReadLine();

        // sök efter fordon med reg nr
        for (int i = 0; i < garage.Length; i++)
        {
            if (!string.IsNullOrEmpty(garage[i]) && garage[i].Contains(registration))
            {
                if (garage[i].StartsWith("MC#"))
                {
                    // om parkeringsrutan innehåller dubbla motorcyklar, dela och hitta den rätta
                    string[] vehicles = garage[i].Split('|');
                    for (int j = 0; j < vehicles.Length; j++)
                    {
                        if (vehicles[j].Contains(registration))
                        {
                            vehicles[j] = ""; //markera specifik motorcykel för att hämta
                            Console.WriteLine($"Hämtar motorcykel med reg nr {registration} från ruta {i + 1}.");
                            // uppdatera parkeringslistan
                            garage[i] = string.Join("|", vehicles).Trim('|'); // ta bort tomma inlägg
                            if (string.IsNullOrEmpty(garage[i]))
                            {
                                garage[i] = ""; // Rensa utrymmet om det nu är tomt
                            }
                            return;
                        }
                    }
                }
                else // det är ett fordon
                {
                    Console.WriteLine($"hämta fordon: {garage[i]} från ruta {i + 1}.");
                    garage[i] = ""; // rensa parkeringsruta
                    return;
                }
            }
        }

        Console.WriteLine("hittar ej fordon.");
    }

    static void MoveVehicle(string[] garage)
    {
        Console.Write("Ange aktuellt nummer på parkeringsplats (1-100): ");
        if (int.TryParse(Console.ReadLine(), out int currentSpace) && currentSpace >= 1 && currentSpace <= 100)
        {
            int currentIndex = currentSpace - 1;

            if (!string.IsNullOrEmpty(garage[currentIndex]))
            {
                Console.Write("Ange nytt nummer på parkeringsplatsen (1-100): ");
                if (int.TryParse(Console.ReadLine(), out int newSpace) && newSpace >= 1 && newSpace <= 100)
                {
                    int newIndex = newSpace - 1;

                    if (string.IsNullOrEmpty(garage[newIndex]))
                    {
                        garage[newIndex] = garage[currentIndex]; // flytta fordon
                        garage[currentIndex] = ""; // rensa gammal ruta
                        Console.WriteLine($"Fordon flyttad från ruta {currentSpace} Till {newSpace}.");
                    }
                    else
                    {
                        Console.WriteLine("Det angivna rutan är upptagen.");
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig ruta.");
                }
            }
            else
            {
                Console.WriteLine("Inget fordon hittades i det aktuella rutan.");
            }
        }
        else
        {
            Console.WriteLine("Ogiltig ruta.");
        }
    }

    static void SearchVehicle(string[] garage)
    {
        Console.Write("Ange reg nr för att söka: ");
        string registration = Console.ReadLine();

        for (int i = 0; i < garage.Length; i++)
        {
            if (garage[i].Contains(registration))
            {
                Console.WriteLine($"Fordon hittad på ruta {i + 1}: {garage[i]}.");
                return;
            }
        }

        Console.WriteLine("Fordonet hittades inte.");
    }

    static void ViewParkingStatus(string[] garage)
    {
        Console.WriteLine("Parkering Status:");
        for (int i = 0; i < garage.Length; i++)
        {
            string status = string.IsNullOrEmpty(garage[i]) ? "Tom" : garage[i];
            Console.WriteLine($"Ruta {i + 1}: {status}");
        }
    }
}

# Prague Parking System V1

Detta är ett enkelt parkeringshanteringssystem utvecklat i C# för att hantera en parkeringsplats där bilar och motorcyklar kan parkeras. Systemet stöder parkering, förflyttning, sökning och hämtning av fordon.

## Innehållsförteckning
- [Introduktion](#introduktion)
- [Funktioner](#funktioner)
- [Installation](#installation)
- [Användning](#användning)
- [Bidra till projektet](#bidra-till-projektet)
- [Licens](#licens)

## Introduktion

**Prague Parking System** gör det möjligt för personal på parkeringsplatsen att hantera fordon genom att parkera, flytta, söka och hämta dem. Systemet är designat för att identifiera fordon genom registreringsnummer.

Detta projekt är en del av en labbuppgift och sparar ingen data när applikationen stängs, vilket innebär att all data går förlorad vid stängning.

## Funktioner

- Parkera en bil eller motorcykel.
- Dubbelparkera två motorcyklar på samma plats.
- Flytta fordon mellan olika parkeringsplatser.
- Hämta fordon baserat på registreringsnummer.
- Visa aktuell status för parkeringsplatsen.
- Sök efter fordon med registreringsnummer.

## Installation

### Förutsättningar
- Du måste ha **.NET Core SDK** installerat på din dator. Du kan ladda ner det från [här](https://dotnet.microsoft.com/download/dotnet-core).

### Steg
1. Klona detta repository till din lokala dator:
   ```bash
   git clone https://github.com/användarnamn/PragueParking.git
Gå till projektkatalogen:

bash
Kopiera kod
cd PragueParking
Bygg projektet med .NET CLI:

bash
Kopiera kod
dotnet build
Kör applikationen:

bash
Kopiera kod
dotnet run
Användning
När applikationen körs visas en textbaserad meny där du kan utföra följande åtgärder:

Parkera ett fordon - Parkera en bil eller motorcykel. Om det är en motorcykel kan du parkera upp till två på samma plats.
Hämta ett fordon - Hämta ett fordon baserat på registreringsnummer. Om en motorcykel delar en plats med en annan motorcykel, tas endast den angivna motorcykeln bort.
Flytta ett fordon - Flytta ett fordon från en parkeringsplats till en annan.
Sök efter ett fordon - Sök efter ett fordon genom att ange registreringsnummer.
Visa parkeringsstatus - Visa status för alla parkeringsplatser (om de är tomma, innehåller bilar eller motorcyklar).
Exempel på interaktion
markdown
Kopiera kod
Prague Parking System
1. Parkera ett fordon
2. Hämta ett fordon
3. Flytta ett fordon
4. Sök efter ett fordon
5. Visa parkeringsstatus
6. Avsluta
Välj ett alternativ: 1
Ange fordonstyp (CAR/MC): CAR
Ange registreringsnummer (max 10 tecken): ABC123
Fordon parkerat på plats 5.
Speciella anmärkningar
Fordon identifieras genom deras registreringsnummer (t.ex. "ABC123").
Parkeringsplatser är numrerade 1 till 100, men internt börjar arrayen från index 0 (så plats 1 lagras på index 0).
Varje plats kan innehålla:
1 Bil, eller
1 Motorcykel, eller
2 Motorcyklar
Bidra till projektet
Om du vill bidra till projektet, vänligen forka repository och skapa en pull request med dina ändringar. Säkerställ att alla tester går igenom och att koden följer projektets stilriktlinjer.

Steg för att bidra:
Forka projektet
Skapa en ny branch:
bash
Kopiera kod
git checkout -b feature-branch
Gör dina ändringar och commit:
bash
Kopiera kod
git commit -m "Beskrivning av funktionen"
Skjut upp ändringarna till din branch:
bash
Kopiera kod
git push origin feature-branch
Skapa en pull request
Licens
Detta projekt är licensierat under MIT-licensen. Se filen LICENSE för mer information.

markdown
Kopiera kod

### Förklaring av hur länkarna fungerar:
- **`#användning`**: Länken för rubriken "Användning" omvandlas till `#användning` (små bokstäver och bindestreck istället för mellanslag).
- **`#bidra-till-projektet`**: Länken för rubriken "Bidra till projektet" blir `#bidra-till-projektet`.
- **`#licens`**: Rubriken "Licens" blir helt enkelt `#licens`.

### Slutsats
Med dessa justeringar bör länkarna nu fungera korrekt i din innehållsförteckning. Se till att alla rubriker är korrekt länkade genom att matcha dem exakt med hur de ser ut längre ned i dokumentet (små bokstäver och bindestreck).






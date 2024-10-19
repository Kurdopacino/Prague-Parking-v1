# Prague Parking System V1

Detta är ett enkelt parkeringshanteringssystem utvecklat i C# för att hantera en parkeringsplats där bilar och motorcyklar kan parkeras. Systemet stöder parkering, förflyttning, sökning och hämtning av fordon.

## Innehållsförteckning
- [Introduktion](#introduktion)
- [Funktioner](#funktioner)
- [Installation](#installation)
- [Användning](#användning)
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
   git clone https://github.com/Kurdopacino/Prague-Parking-v1.git



## Användning

1. **Starta programmet**: När applikationen startas, visas en meny med de tillgängliga alternativen.
2. **Välj ett alternativ**: 
Ange ett nummer som motsvarar den önskade funktionen:
   - `1` för att parkera ett fordon.
   - `2` för att hämta ett fordon.
   - `3` för att flytta ett fordon till en annan parkeringsplats.
   - `4` för att söka ett fordon via dess registreringsnummer.
   - `5` för att visa aktuell parkeringsstatus.
   - `6` för att avsluta programmet.

3. **Parkera ett fordon**: När du parkerar, måste du ange fordonstyp ('BIL' för bil eller 'MC' för motorcykel) och ett giltigt registreringsnummer.
4. **Hämta ett fordon**: För att hämta ett fordon, ange registreringsnumret och systemet hittar fordonet och markerar platsen som ledig igen.
5. **Flytta ett fordon**: Ange den aktuella och den nya parkeringsrutan för att flytta ett fordon.
6. **Sök ett fordon**: Ange registreringsnumret så visar systemet vilken ruta fordonet står på om det finns i garaget.

## Exempel på användning

```plaintext
Välkommen till Prague Parking
Antal parkeringsplatser: 100
Timpris för bil: 20,00 kr
Timpris för motorcykel: 10,00 kr

Prague Parking System
1. Parkera Fordon
2. Hämta Fordon
3. Flytta Fordon
4. Sök Fordon på Reg nr
5. Visa aktuell parkerings vy
6. Avsluta
Välj ett alternativ: 
```

## Licens
Detta projekt är open-source och kan modifieras och distribueras fritt.

Den här README-filen ger en översikt och gör det lättare för andra att förstå och använda projektet.


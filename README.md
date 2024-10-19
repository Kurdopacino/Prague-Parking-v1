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

less
Kopiera kod

### Hur länkarna fungerar
- I markdown skapas interna länkar med hjälp av rubrikens namn, men alla mellanslag i rubrikens text ersätts med bindestreck (`-`) och alla bokstäver omvandlas till små bokstäver.
- Rubriken `## Introduktion` blir till exempel `#introduktion` i länken, så innehållsförteckningen ska ha en länk i formatet `[Introduktion](#introduktion)`.

### Exempel på hur det fungerar:
Om du har rubriken:
```markdown
## Funktioner
Då blir länken till den rubriken:

markdown
Kopiera kod
[Funktioner](#funktioner)


### Förklaring av sektionerna:

1. **Projektets titel och beskrivning**: En kort introduktion om vad projektet gör och varför det är viktigt.
  
2. **Innehållsförteckning**: Hjälper användare att navigera i README-filen, särskilt om den är lång.

3. **Introduktion**: Kortfattad beskrivning av vad systemet gör och dess syfte.

4. **Funktioner**: En lista över vad systemet kan göra (som att parkera, flytta och hämta fordon).

5. **Installation**: Instruktioner för hur man ställer in projektet på sin egen maskin. I det här fallet hur man installerar och kör en C#-applikation med .NET Core.

6. **Användning**: Beskriver hur användaren ska interagera med systemet och vilka menyer och funktioner som finns. Exempel på interaktion visar hur systemet fungerar i praktiken.

7. **Bidra till projektet**: Förklarar hur andra kan bidra till projektet genom att forka, skapa nya branches och skicka in pull requests.

8. **Licens**: Licensinformation, i det här fallet MIT-licensen.

### Tips:
- **Installation**: Om projektet kräver tredjepartsbibliotek eller specifika inställningar, inkludera det i installationsavsnittet.
- **Användningsexempel**: Lägg till exempel på hur applikationen fungerar med typiska användningsfall.
- **Kontributionsriktlinjer**: Om du vill uppmuntra bidrag, se till att tydligt beskriva hur man kan bidra.

Den här README-filen ger en översikt och gör det lättare för andra att förstå och använda ditt projekt.


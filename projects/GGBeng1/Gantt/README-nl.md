# Gantt

## Installatie

```
yarn install
```

### Uitvoeren

```
yarn run serve
```

### Toelichting

```
Een Gantt-diagram ontwikkeld op basis van Vue, geschikt voor team samenwerking, taakverdeling en andere agile scenario’s.

Ondersteunt groepering
Ondersteunt slepen
Ondersteunt uitrekken
Ondersteunt percentage
Ondersteunt tijdsbestek: dag, week, maand
Momenteel is er alleen een groepering op het eerste niveau geïmplementeerd. Om te anticiperen op toekomstige behoeften voor tweede of meervoudige groeperingen, is een deel van de code bij de laatste commit herbouwd om multi-level groepering te ondersteunen, maar deze versie heeft deze functionaliteit nog niet ontwikkeld.

Voordelen: Tijdens het slepen, uitrekken of bijwerken van de voortgang worden de gegevens niet in real-time bijgewerkt, maar pas na de bewerking, wat het prestatienadeel vermindert.
      Bij het bewerken, verwijderen of toevoegen worden niet alle instanties recursief aangepast, maar alleen de gewijzigde delen.

Momenteel wordt het project heringericht ter voorbereiding op componentisatie. Voor gebruik in een project hoeft alleen `gant.vue` uit dit project te worden geïmporteerd.
Methoden voor batch data importeren/exporteren zijn reeds geschreven en kunnen direct gekopieerd worden!~

```

### Updatebeschrijving

- Ondersteunt bewerken
- Ondersteunt verwijderen
- Opgelost: bug waarbij niet verticaal gescrold kon worden (tegelijk bidirectioneel scrollen toegevoegd) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Opgelost: bug veroorzaakt door elementUI
- Over het probleem met tijdsbestek [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Het is momenteel niet mogelijk om andere tijdsbestekken te realiseren door de configuratie aan te passen, zoals het toevoegen van uren. Sommige instellingen zijn bij de initialisatie vastgelegd; dit zal later als API worden vrijgegeven.


### Voorbeeld bekijken

Zie [demo](https://ggbeng1.github.io/Gantt/#/)

### Voorbeeldafbeelding

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
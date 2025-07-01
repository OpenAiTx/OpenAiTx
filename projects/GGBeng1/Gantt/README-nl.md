# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## Installatie

```
yarn install
```

### Uitvoeren

```
yarn run serve
```

### Uitleg

```
Gantt-diagram ontwikkeld op basis van Vue, kan worden gebruikt voor teamcoördinatie, taakverdeling en andere agile scenario's.

Ondersteunt groepering
Ondersteunt slepen
Ondersteunt uitrekken
Ondersteunt percentage
Ondersteunt tijdsspanne: dag, week, maand
Op dit moment is alleen groepering op één niveau geïmplementeerd. Om toekomstige behoeften voor twee- of meerlagige groepering te voorkomen, is bij de vorige commit een deel van de code herbouwd om meerlagige groepering te ondersteunen, maar deze versie heeft die functionaliteit nog niet.

Voordelen: Bij slepen, uitrekken, het wijzigen van voortgang en soortgelijke acties wordt de data niet direct realtime bijgewerkt, maar pas na de actie, wat het prestatienadeel vermindert.
      Bij bewerken, verwijderen, toevoegen wordt niet de hele instantie recursief aangepast, maar alleen het gewijzigde deel toegevoegd, verwijderd of aangepast.

Momenteel wordt de code heringericht ter voorbereiding op componentisatie. Wil je het nu in je project gebruiken, importeer dan gewoon `gant.vue` uit dit project.
Methoden voor bulk data importeren en exporteren zijn reeds geschreven, je kunt ze direct kopiëren!~

```

### Update-opmerkingen

- Ondersteunt bewerken
- Ondersteunt verwijderen
- Opgelost: bug waardoor verticaal scrollen niet mogelijk was (tevens tweezijdig scrollen toegevoegd) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Opgelost: bug veroorzaakt door elementUI
- Over het probleem met tijdsspanne [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Het is momenteel niet mogelijk om door wijziging van de tijdsspanne-configuratie andere intervallen te realiseren, bijvoorbeeld uren toevoegen. Bepaalde configuraties zijn bij de initialisatie vastgezet; dit zal in de toekomst worden aangepast en als API beschikbaar komen.

### Voorbeeld bekijken

Zie [demo](https://ggbeng1.github.io/Gantt/#/)

### Voorbeeldweergave

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---